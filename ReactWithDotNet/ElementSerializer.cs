using System.Collections;
using System.Reflection;
using System.Text.Json.Serialization;

namespace ReactWithDotNet;

sealed class Tracer
{
    public int IndentLevel { get; set; }

    internal readonly LinkedList<string> Messages = new();

    public void Trace(string message)
    {
        Messages.AddLast("".PadRight(IndentLevel) + message);
    }

    public void Trace(LinkedList<string> messageList)
    {
        foreach (var message in messageList)
        {
            Trace(message);
        }
    }
}

sealed class ElementSerializerContext
{
    public readonly Tracer Tracer = new();

    internal readonly Stack<ReactComponentBase> ComponentStack = new();

    internal readonly DynamicStyleContentForEmbedInClient DynamicStyles = new();

    public Action<Element, ReactContext> BeforeSerializeElementToClient { get; init; }

    public bool CalculateSuspenseFallbackForThirdPartyReactComponents { get; set; }

    public int ComponentUniqueIdentifierNextValue { get; set; }

    public ReactContext ReactContext { get; init; }

    public bool SkipHandleCacheableMethods { get; set; }

    public StateTree StateTree { get; init; }
}

static partial class ElementSerializer
{
    const string ___HasComponentDidMountMethod___ = "$HasComponentDidMountMethod";
    const string ___RootNode___ = "$RootNode";
    const string ___Type___ = "$Type";
    const string ___TypeOfState___ = "$TypeOfState";

    static readonly ValueExportInfo<object> NotExportableObject = ValueExportInfo<object>.NotExportable;

    public static IReadOnlyList<CssPseudoCodeInfo> CalculatePseudos(Style style)
    {
        if (style is null)
        {
            return null;
        }

        List<CssPseudoCodeInfo> pseudos = null;

        if (style._hover is not null)
        {
            // ReSharper disable once UseObjectOrCollectionInitializer
            pseudos = new List<CssPseudoCodeInfo>();

            pseudos.Add(new CssPseudoCodeInfo
            {
                Name      = "hover",
                BodyOfCss = style._hover.ToCssWithImportant()
            });
        }

        if (style._before is not null)
        {
            pseudos ??= new List<CssPseudoCodeInfo>();

            pseudos.Add(new CssPseudoCodeInfo
            {
                Name      = "before",
                BodyOfCss = style._before.ToCssWithImportant()
            });
        }

        if (style._after is not null)
        {
            pseudos ??= new List<CssPseudoCodeInfo>();

            pseudos.Add(new CssPseudoCodeInfo
            {
                Name      = "after",
                BodyOfCss = style._after.ToCssWithImportant()
            });
        }

        if (style._active is not null)
        {
            pseudos ??= new List<CssPseudoCodeInfo>();

            pseudos.Add(new CssPseudoCodeInfo
            {
                Name      = "active",
                BodyOfCss = style._active.ToCssWithImportant()
            });
        }

        if (style._focus is not null)
        {
            pseudos ??= new List<CssPseudoCodeInfo>();

            pseudos.Add(new CssPseudoCodeInfo
            {
                Name      = "focus",
                BodyOfCss = style._focus.ToCssWithImportant()
            });
        }

        return pseudos;
    }

    internal static void InitializeKeyIfNotExists(Element element)
    {
        if (element.key == null)
        {
            throw new DeveloperException("key of react component cannot be null");
        }

        var children = element._children;
        if (children == null)
        {
            return;
        }

        var childrenCount = children.Count;

        for (var index = 0; index < childrenCount; index++)
        {
            var sibling = children[index];
            if (sibling is not null)
            {
                sibling.key = index.ToString();
            }
        }
    }

    static (bool needToExport, string cssClassName) ConvertStyleToCssClass(Style style,
                                                                           bool fullExport,
                                                                           int? componentUniqueIdentifier,
                                                                           Func<CssClassInfo, string> getCssClassName)
    {
        if (style is null)
        {
            return (false, null);
        }

        var pseudos = CalculatePseudos(style);

        if (fullExport)
        {
            if (style.IsEmpty && pseudos is null && style._mediaQueries is null)
            {
                return (false, null);
            }
        }
        else
        {
            if (pseudos is null && style._mediaQueries is null)
            {
                return (false, null);
            }
        }

        componentUniqueIdentifier ??= 1;

        var cssClassInfo = new CssClassInfo
        {
            ComponentUniqueIdentifier = componentUniqueIdentifier,
            Name                      = "_rwd_" + componentUniqueIdentifier + "_",
            Pseudos                   = pseudos,
            MediaQueries              = calculateMediaQueries(style._mediaQueries),
            Body                      = fullExport ? style.ToCssWithImportant() : null
        };

        return (true, getCssClassName(cssClassInfo));

        static IReadOnlyList<(string mediaRule, string cssBody)> calculateMediaQueries(List<MediaQuery> mediaQueries)
        {
            if (mediaQueries == null || mediaQueries.Count == 0)
            {
                return null;
            }

            var uniqueList = new List<(string mediaRule, string cssBody)>();

            foreach (var mediaQuery in mediaQueries)
            {
                var mediaRule = mediaQuery.Query;
                var cssBody   = mediaQuery.Style.ToCssWithImportant();

                if (!uniqueList.Any(x => x.mediaRule == mediaRule && x.cssBody == cssBody))
                {
                    uniqueList.Add((mediaRule, cssBody));
                }
            }

            return uniqueList;
        }
    }

    static BindInfo GetExpressionAsBindingInfo(PropertyInfo propertyInfo, Func<(IReadOnlyList<string> path, bool isConnectedToState)> calculateSourcePathFunc)
    {
        var reactBindAttribute = propertyInfo.GetCustomAttribute<ReactBindAttribute>();
        if (reactBindAttribute == null)
        {
            return null;
        }

        var transformValueInClientAttribute = propertyInfo.GetCustomAttribute<ReactTransformValueInClientAttribute>();

        var (path, isConnectedToState) = calculateSourcePathFunc();
        return new BindInfo
        {
            targetProp        = reactBindAttribute.targetProp,
            eventName         = reactBindAttribute.eventName,
            sourcePath        = path,
            sourceIsState     = isConnectedToState,
            IsBinding         = true,
            jsValueAccess     = reactBindAttribute.jsValueAccess.Split('.', StringSplitOptions.RemoveEmptyEntries),
            transformFunction = transformValueInClientAttribute?.TransformFunction
        };
    }

    static string GetPropertyName(PropertyInfo propertyInfo)
    {
        var propertyName = propertyInfo.Name;

        var jsonPropertyNameAttribute = propertyInfo.GetCustomAttribute<JsonPropertyNameAttribute>();
        if (jsonPropertyNameAttribute != null)
        {
            propertyName = jsonPropertyNameAttribute.Name;
        }

        return propertyName;
    }

    static async Task<ValueExportInfo<object>> GetPropertyValue(TypeInfo typeInfo,object instance, PropertyAccessInfo property, ElementSerializerContext context)
    {
        var propertyInfo = property.PropertyInfo;

        var propertyValue = property.GetValueFunc(instance);

        var isDefaultValue = propertyValue == property.DefaultValue;
        if (isDefaultValue)
        {
            return NotExportableObject;
        }

        if (typeInfo.GetPropertyValueForSerializeToClient is not null)
        {
            var output = typeInfo.GetPropertyValueForSerializeToClient(instance, propertyInfo.Name);
            if (output.needToExport)
            {
                return output.value;
            }
        }
        
        if (property.TransformValueInServerSide != null)
        {
            string convertStyleToCssClass(Style style)
            {
                var (needToExport, cssClassName) = ConvertStyleToCssClass(style, true, context.ComponentStack.PeekForComponentUniqueIdentifier(), context.DynamicStyles.GetClassName);
                if (needToExport)
                {
                    return cssClassName;
                }

                return string.Empty;
            }

            {
                var (needToExport, newValue) = property.TransformValueInServerSide(propertyValue, new TransformValueInServerSideContext(convertStyleToCssClass));
                if (needToExport == false)
                {
                    return NotExportableObject;
                }

                return newValue;
            }
        }

        // check inline
        {
            if (propertyValue is Style style)
            {
                return GetStylePropertyValueOfHtmlElementForSerialize(instance, style, context);
            }
        }

        if (propertyValue is Action action)
        {
            if (action.Target is ReactComponentBase target)
            {
                propertyValue = new RemoteMethodInfo
                {
                    IsRemoteMethod                   = true,
                    remoteMethodName                 = action.Method.GetNameWithToken(),
                    HandlerComponentUniqueIdentifier = target.ComponentUniqueIdentifier
                };
            }
            else
            {
                throw HandlerMethodShouldBelongToReactComponent(propertyInfo, action.Target);
            }
        }

        if (propertyInfo.PropertyType.IsGenericType)
        {
            if (propertyInfo.PropertyType.IsGenericAction1Or2Or3())
            {
                var @delegate = (Delegate)propertyValue;
                if (@delegate is not null)
                {
                    if (@delegate.Target is ReactComponentBase target)
                    {
                        propertyValue = new RemoteMethodInfo
                        {
                            IsRemoteMethod                   = true,
                            remoteMethodName                 = @delegate.Method.GetNameWithToken(),
                            HandlerComponentUniqueIdentifier = target.ComponentUniqueIdentifier,
                            FunctionNameOfGrabEventArguments = propertyInfo.GetCustomAttribute<ReactGrabEventArgumentsByUsingFunctionAttribute>()?.TransformFunction,
                            StopPropagation                  = @delegate.Method.GetCustomAttribute<ReactStopPropagationAttribute>() is not null
                        };
                    }
                    else
                    {
                        throw HandlerMethodShouldBelongToReactComponent(propertyInfo, @delegate.Target);
                    }
                }
            }
        }

        if (propertyValue is Enum enumValue)
        {
            propertyValue = enumValue.ToString();
        }

        if (propertyValue is Expression<Func<int>> ||
            propertyValue is Expression<Func<double>> ||
            propertyValue is Expression<Func<string>> ||
            propertyValue is Expression<Func<bool>>)
        {
            static object getTargetValueFromExpression(PropertyInfo pi, LambdaExpression lambdaExpression)
            {
                var expression = lambdaExpression.Body;
                while (true)
                {
                    if (expression is MemberExpression memberExpression)
                    {
                        expression = memberExpression.Expression;
                        continue;
                    }

                    if (expression is ConstantExpression constantExpression)
                    {
                        return constantExpression.Value;
                    }

                    if (expression is MethodCallExpression methodCallExpression)
                    {
                        expression = methodCallExpression.Object;
                        continue;
                    }

                    throw HandlerMethodShouldBelongToReactComponent(pi, lambdaExpression.ToString());
                }
            }

            (IReadOnlyList<string> path, bool isConnectedToState) calculateSourcePathFunc()
            {
                if (propertyValue is Expression<Func<string>> bindingExpressionAsString)
                {
                    return bindingExpressionAsString.AsBindingPath();
                }

                if (propertyValue is Expression<Func<int>> bindingExpressionAsInt32)
                {
                    return bindingExpressionAsInt32.AsBindingPath();
                }

                if (propertyValue is Expression<Func<bool>> bindingExpressionAsBoolean)
                {
                    return bindingExpressionAsBoolean.AsBindingPath();
                }
                
                if (propertyValue is Expression<Func<double>> bindingExpressionAsDouble)
                {
                    return bindingExpressionAsDouble.AsBindingPath();
                }

                throw new NotImplementedException();
            }

            var bindInfo = GetExpressionAsBindingInfo(propertyInfo, calculateSourcePathFunc);
            if (bindInfo == null)
            {
                return NotExportableObject;
            }

            if (getTargetValueFromExpression(propertyInfo, propertyValue as LambdaExpression) is ReactComponentBase target)
            {
                bindInfo.HandlerComponentUniqueIdentifier = target.ComponentUniqueIdentifier;
            }

            var debounceTimeout = instance.GetType().GetProperty(propertyInfo.Name + "DebounceTimeout")?.GetValue(instance) as int?;
            if (debounceTimeout > 0)
            {
                if (instance.GetType().GetProperty(propertyInfo.Name + "DebounceHandler")?.GetValue(instance) is Action debounceHandler)
                {
                    bindInfo.DebounceTimeout = debounceTimeout;
                    bindInfo.DebounceHandler = debounceHandler.Method.GetNameWithToken();
                }
            }

            return bindInfo;
        }

        if (propertyValue is HtmlTextNode htmlTextNode)
        {
            return htmlTextNode.innerText;
        }

        if (propertyValue is Element element)
        {
            element.key ??= propertyInfo.Name;

            propertyValue = new InnerElementInfo
            {
                IsElement = true,
                Element   = await element.ToJsonMap(context)
            };
        }

        var templateAttribute = propertyInfo.GetCustomAttribute<ReactTemplateAttribute>();
        if (templateAttribute is not null)
        {
            var func = (Delegate)propertyInfo.GetValue(instance);
            if (func == null)
            {
                return NotExportableObject;
            }

            var method = instance.GetType().GetMethod(templateAttribute.MethodNameForGettingItemsSource, BindingFlags.Instance | BindingFlags.NonPublic);
            if (method == null)
            {
                throw new MissingMethodException(templateAttribute.MethodNameForGettingItemsSource);
            }

            Task<IReadOnlyJsonMap> convertToReactNode(object item)
            {
                var reactNode = (Element)func.DynamicInvoke(item);
                if (reactNode is not null && item is not null)
                {
                    reactNode.key ??= item.GetType().GetProperty("key")?.GetValue(item)?.ToString() ?? "0";
                }

                return reactNode.ToJsonMap(context);
            }

            var itemTemplates = (IEnumerable)method.Invoke(instance, new object[] { });

            var results = new List<ItemTemplateInfo>();

            if (itemTemplates is not null)
            {
                foreach (var item in itemTemplates)
                {
                    results.Add(new ItemTemplateInfo { Item = item, ElementAsJson = await convertToReactNode(item) });
                }
            }

            var template = new ItemTemplate
            {
                ___ItemTemplates___ = results
            };

            if (propertyInfo.GetCustomAttribute<ReactTemplateForNullAttribute>() is not null)
            {
                template.___TemplateForNull___ = await convertToReactNode(null);
            }

            return template;
        }

        var reactTransformValueInClient = propertyInfo.GetCustomAttribute<ReactTransformValueInClientAttribute>();
        if (reactTransformValueInClient is not null)
        {
            var jsonMap = new JsonMap();

            jsonMap.Add("$transformValueFunction", reactTransformValueInClient.TransformFunction);
            jsonMap.Add("RawValue", propertyValue);

            return jsonMap;
        }

        return propertyValue;
    }

    static string GetReactComponentTypeInfo(object reactStatefulComponent)
    {
        return reactStatefulComponent.GetType().GetFullName();
    }

    static ValueExportInfo<object> GetStylePropertyValueOfHtmlElementForSerialize(object instance, Style style, ElementSerializerContext context)
    {
        var response = ConvertStyleToCssClass(style, false, context.ComponentStack.PeekForComponentUniqueIdentifier(), context.DynamicStyles.GetClassName);
        if (response.needToExport is false)
        {
            if (style.IsEmpty == false)
            {
                return style;
            }

            return NotExportableObject;
        }

        var pseudos = CalculatePseudos(style);

        if (pseudos is not null || style._mediaQueries is not null)
        {
            var cssClassName = response.cssClassName;

            if (instance is HtmlElement htmlElement)
            {
                htmlElement.AddClass(cssClassName);
            }
            else if (instance is ThirdPartyReactComponent thirdPartyReactComponent)
            {
                thirdPartyReactComponent.AddClass(cssClassName);
            }
            else
            {
                throw new NotImplementedException("Style attribute problem occurred.");
            }
        }

        if (style.IsEmpty)
        {
            return NotExportableObject;
        }

        return style;
    }

    

    static Exception HandlerMethodShouldBelongToReactComponent(PropertyInfo propertyInfo, object handlerTarget)
    {
        throw DeveloperException(string.Join(Environment.NewLine,
                                             "Delegate method should belong to ReactComponent. ",
                                             "Please give named method to " + propertyInfo.DeclaringType?.FullName + "::" + propertyInfo.Name,
                                             $"How to fix: inherit {handlerTarget?.GetType().FullName} class from ReactComponent."));
    }

    static Exception HandlerMethodShouldBelongToReactComponent(PropertyInfo propertyInfo, string bindingPath)
    {
        throw new InvalidOperationException("Delegate method should belong to ReactComponent. Please give named method to " + propertyInfo.DeclaringType?.FullName + "::" + propertyInfo.Name + $" Given bindingPath:{bindingPath} is invalid.");
    }

    static bool HasComponentDidMountMethod(object reactStatefulComponent)
    {
        var componentType = reactStatefulComponent.GetType();

        var didMountMethodInfo = componentType.FindMethod("componentDidMount", BindingFlags.NonPublic | BindingFlags.Instance);
        if (didMountMethodInfo != null)
        {
            if (didMountMethodInfo.DeclaringType != typeof(ReactComponentBase))
            {
                return true;
            }
        }

        return false;
    }

    static void TryCallBeforeSerializeElementToClient(this ElementSerializerContext context, Element element)
    {
        if (element is null || context.BeforeSerializeElementToClient is null)
        {
            return;
        }

        context.BeforeSerializeElementToClient(element, context.ReactContext);
    }

    class CacheableMethodInfo
    {
        public IReadOnlyJsonMap ElementAsJson { get; set; }
        public bool IgnoreParameters { get; set; }
        public string MethodName { get; set; }
        public object Parameter { get; set; }
    }
    
    sealed class ValueExportInfo<TValue> where TValue : class
    {
        public static readonly ValueExportInfo<TValue> NotExportable = new();
        public readonly bool NeedToExport;
        public readonly TValue Value;

        ValueExportInfo(TValue value)
        {
            Value   = value;
            NeedToExport = true;
        }

        ValueExportInfo()
        {
            Value        = default;
            NeedToExport = false;
        }

        public static implicit operator ValueExportInfo<TValue>(TValue value) => new(value);
    }
}

class ItemTemplate
{
    public IEnumerable<ItemTemplateInfo> ___ItemTemplates___ { get; set; }
    public IReadOnlyJsonMap ___TemplateForNull___ { get; set; }
}

sealed class ItemTemplateInfo
{
    public IReadOnlyJsonMap ElementAsJson { get; set; }
    public object Item { get; set; }
}