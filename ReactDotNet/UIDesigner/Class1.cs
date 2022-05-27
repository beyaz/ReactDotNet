﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using ReactDotNet.PrimeReact;
using static ReactDotNet.Mixin;

namespace ReactDotNet.UIDesigner;

[Serializable]
public class UIDesignerModel
{
    public string SelectedComponentTypeReference { get; set; }

    public ClientTask ClientTask { get; set; }

    public IReadOnlyList<DotNetObjectPropertyValue> Properties { get; set; }

    public string SaveDirectoryPath { get; set; } = @"d:\\temp\\";


    public string SelectedPropertyName { get; set; }
    public string SelectedPropertyValue { get; set; }

    public int ScreenWidth { get; set; }
}

public class ReactComponentInfo
{
    public string Name { get; set; }
    public string Value { get; set; }
}

public class Pair
{
    public string Key { get; set; }
    public string Value { get; set; }
}

[Serializable]
public sealed class DotNetObjectPropertyValue
{
    public string Path { get; set; }
    public string Value { get; set; }
}


static class UIDesignerViewExtension
{
    public static void TryUpdateFirst<T>(this IEnumerable<T> enumerable, Func<T, bool> findFunction, Action<T> update)
    {
        var value = enumerable.FirstOrDefault(findFunction);
        if (value is not null)
        {
            update(value);
        }
    }
}

public class UIDesignerView:ReactComponent<UIDesignerModel>
{


    static Exception SaveValueToPropertyPath(object value, object instance, string propertyPath)
    {
        if (instance == null)
        {
            return new ArgumentNullException(nameof(instance));
        }

        while (true)
        {
            var parts = propertyPath.Split('.');

            var propertyInfo = instance.GetType().GetProperty(parts[0]);

            if (propertyInfo == null)
            {
                return new MissingMemberException(instance.GetType().FullName, parts[0]);
            }

            if (parts.Length == 1)
            {
                propertyInfo.SetValue(instance, value, null);
            }
            else
            {
                var innerInstance = propertyInfo.GetValue(instance);
                if (innerInstance == null)
                {
                    innerInstance = Activator.CreateInstance(propertyInfo.PropertyType);
                    if (innerInstance == null)
                    {
                        return new NullReferenceException(propertyInfo.Name);
                    }
                    propertyInfo.SetValue(instance, innerInstance);
                }

                instance     = innerInstance;
                propertyPath = string.Join(".", parts.Skip(1));

                continue;
            }

            break;
        }

        return null;
    }


    void SaveProperties(string typeReference, IEnumerable<DotNetObjectPropertyValue> items)
    {
        var filePath = GetCacheFilePath(typeReference);

        File.WriteAllText(filePath, JsonSerializer.Serialize(items, new JsonSerializerOptions {WriteIndented = true}));
    }

    string GetCacheFilePath(string typeReference) => state.SaveDirectoryPath + typeReference + ".json";

    IEnumerable<DotNetObjectPropertyValue> ReadProperties(string typeReference)
    {
        var filePath = GetCacheFilePath(typeReference);

        if (!File.Exists(filePath))
        {
            return Enumerable.Empty<DotNetObjectPropertyValue>();
        }
        var json = File.ReadAllText(filePath);

        return JsonSerializer.Deserialize<IEnumerable<DotNetObjectPropertyValue>>(json);
    }

    static IEnumerable<DotNetObjectPropertyValue> GetProperties(Type type)
    {
        foreach (var propertyInfo in type.GetProperties())
        {
            if (propertyInfo.PropertyType.IsAbstract)
            {
                continue;
            }

            yield return new DotNetObjectPropertyValue {Path = propertyInfo.Name};
        }
    }

    void SaveState()
    {
        File.WriteAllText(@"d:\\temp\\UIDesignerModel.json",JsonSerializer.Serialize(state));
    }

    UIDesignerModel ReadState()
    {
        if (File.Exists(@"d:\\temp\\UIDesignerModel.json"))
        {
            var json = File.ReadAllText(@"d:\\temp\\UIDesignerModel.json");

            try
            {
                return JsonSerializer.Deserialize<UIDesignerModel>(json);
            }
            catch (Exception )
            {
                return new UIDesignerModel();
            }
        }

        return new UIDesignerModel();

    }

    public override void constructor()
    {
        state = ReadState();
        state.ClientTask = new ClientTaskListenComponentEvent
        {
            EventName     = ReactComponentEvents.componentDidMount.ToString(),
            RouteToMethod = nameof(OnFirstLoaded)
        };
    }

    static IEnumerable<ReactComponentInfo> GetComponents(Assembly assembly)
    {
        foreach (var type in assembly.GetTypes())
        {
            if (type.IsAbstract)
            {
                continue;
            }

            if(IsReactComponent(type))
            {
                yield return new ReactComponentInfo {Name = type.GetFullName(), Value = type.GetFullName() };
            }
        }
    }

    static bool IsReactComponent(Type type)
    {
        if (type.IsSubclassOf(typeof(ReactComponent)))
        {
            return true;
        }
        
        return IsReactStatefulComponent(type);
    }

    static bool IsReactStatefulComponent(Type type)
    {
        type = type.BaseType;

        if (type?.IsGenericType == true )
        {
            var typeDefinition = type.GetGenericTypeDefinition();
            if (typeDefinition == typeof(ReactComponent<>) || typeDefinition.IsSubclassOf(typeof(ReactComponent<>)))
            {
                return true;
            }
            
        }

        return false;
    }

    IReadOnlyList<ReactComponentInfo> Suggestions => GetComponents(Assembly.Load("QuranAnalyzer.WebUI")).ToList();

    public void OnFirstLoaded()
    {
    }

   

    public override Element render()
    {
        SaveState();

        var componentSelector = new ListBox
        {
            options     = Suggestions,
            optionLabel = nameof(ReactComponentInfo.Name),
            optionValue = nameof(ReactComponentInfo.Value),
            value       = state.SelectedComponentTypeReference,
            onChange    = OnSelectedComponentChanged,
            filter      = true,
            listStyle   = { maxHeight = px(400)}
        };


        var propertyList = new ListBox
        {
            options     = (state.Properties ?? Enumerable.Empty<DotNetObjectPropertyValue>()).OrderBy(x => string.IsNullOrWhiteSpace(x.Value)).Select(x=>new Pair{Key = x.Path,Value = x.Path}),
            optionLabel = nameof(Pair.Key),
            optionValue = nameof(Pair.Value),
            value       = state.SelectedPropertyName,
            onChange    = OnSelectedPropertyChanged,
            filter      = true,
            listStyle   = { maxHeight = px(400) }
        };

        var dataPanel = new Splitter
        {
            new SplitterPanel
            {
                propertyList
            },
            new SplitterPanel
            {
                new InputTextarea{value = state.SelectedPropertyValue, onChange =  OnSelectedPropertyValueChanged} | width("100%")
                                                                                                                   | height("100%")
            }
        };


        Element createElement()
        {
            try
            {
                var type = FindType(state.SelectedComponentTypeReference);
                if (type == null)
                {
                    return new div("type not found.");
                }

                var instance = Activator.CreateInstance(type);
                if (instance == null)
                {
                    return new div("instance is null.");
                }

                foreach (var dotNetObjectPropertyValue in state.Properties.Where(x=>!string.IsNullOrWhiteSpace(x.Value)))
                {
                    var path      = dotNetObjectPropertyValue.Path;
                    var jsonValue = dotNetObjectPropertyValue.Value;

                    var propertyInfo = type.GetProperty(path);

                    if (propertyInfo is not null)
                    {
                        object propertyValue = null;
                        if (propertyInfo.PropertyType == typeof(string))
                        {
                            propertyValue = jsonValue;
                        }
                        else
                        {
                            propertyValue = JsonSerializer.Deserialize(jsonValue, propertyInfo.PropertyType);
                        }

                        SaveValueToPropertyPath(propertyValue, instance, path);
                    }
                }

                if (IsReactStatefulComponent(type))
                {
                    var statePropertyInfo = type.GetProperty("state");
                    if (statePropertyInfo is not null)
                    {
                        var stateInstance = statePropertyInfo.GetValue(instance);
                        if (stateInstance == null)
                        {
                            stateInstance = Activator.CreateInstance(statePropertyInfo.PropertyType);

                            statePropertyInfo.SetValue(instance, stateInstance);
                        }

                        OpenNullProperties(stateInstance);
                    }

                    return ((IReactStatefulComponent)instance).RootElement;

                }

                return instance as Element;
            }
            catch (Exception exception)
            {
                return new div(exception.ToString());
            }
        }

        static void OpenNullProperties(object instance)
        {
            if (instance == null)
            {
                return;
            }

            foreach (var propertyInfo in GetNestedProperties(instance.GetType()))
            {
                if (propertyInfo.GetValue(instance) == null)
                {
                    var propertyValue = Activator.CreateInstance(propertyInfo.PropertyType);

                    OpenNullProperties(propertyValue);

                    propertyInfo.SetValue(instance, propertyValue);
                }
            }


            static IEnumerable<PropertyInfo> GetNestedProperties(Type type)
            {
                foreach (var propertyInfo in type.GetProperties())
                {
                    if (propertyInfo.PropertyType == typeof(string))
                    {
                        continue;
                    }

                    if (propertyInfo.PropertyType.IsAbstract)
                    {
                        continue;
                    }

                    if (propertyInfo.PropertyType.IsValueType)
                    {
                        continue;
                    }

                    yield return propertyInfo;
                }
            }
        }

       

        var mainPanel = new Splitter
        {
            layout = SplitterLayoutType.vertical,
            style =
            {
                width  = "100%",
                height = "100%"
            },

            children =
            {
                new SplitterPanel
                {
                    size = 70,
                    children =
                    {
                        new div{ createElement() }
                        | border("1px dashed #e0e0e0")
                        | width("100%")
                        | height("100%")
                    }
                },

                new SplitterPanel
                {
                    size = 30,
                    children =
                    {
                        new div(Display.flex,FlexDirection.column)
                        {
                            new Slider{value = state.ScreenWidth, MarginAll = 10, onSlideEnd = OnWidthChanged},
                            new Splitter
                            {
                                new SplitterPanel
                                {
                                    size     = 2,
                                    children = {componentSelector | height("100%")}
                                },

                                new SplitterPanel
                                {
                                    size     = 6,
                                    children = {dataPanel | width("100%")}
                                }
                            }
                        }
                    }
                }
            }
        };

        return new div { mainPanel } | width("100%")| height("100%")| padding(10);
    }

    void OnWidthChanged(SliderChangeParams e)
    {
        state.ScreenWidth = e.value+5;
    }

    void OnSelectedPropertyValueChanged(SyntheticEvent e)
    {
        state.SelectedPropertyValue = e.target.value;

        if (state.SelectedPropertyName is not null)
        {
            state.Properties.TryUpdateFirst(x => x.Path == state.SelectedPropertyName,x => x.Value = state.SelectedPropertyValue);
        }
    }

    void OnSelectedPropertyChanged(ListBoxChangeParams e)
    {
        state.SelectedPropertyName = e.value;

        state.SelectedPropertyValue = state.Properties.FirstOrDefault(x => x.Path == state.SelectedPropertyName)?.Value;
    }

    void OnSelectedComponentChanged(ListBoxChangeParams e)
    {
        if (!string.IsNullOrWhiteSpace(state.SelectedComponentTypeReference) && state.Properties?.Count > 0)
        {
            SaveProperties(state.SelectedComponentTypeReference, state.Properties);
        }

        state.SelectedComponentTypeReference = e.value;

            

        state.Properties = null;

        var type = FindType(state.SelectedComponentTypeReference);
        if (type != null)
        {
            state.Properties = GetProperties(type).ToList();

            foreach (var item in ReadProperties(state.SelectedComponentTypeReference))
            {
                var entry = state.Properties.FirstOrDefault(x=>x.Path == item.Path);
                if (entry != null)
                {
                    entry.Value = item.Value;
                }
                    
            }
        }
    }

    static Type FindType(string typeReference)
    {
        if (!string.IsNullOrWhiteSpace(typeReference))
        {
            return Type.GetType(typeReference, false);
        }

        return null;
    }


    
}