﻿using System.Globalization;
using System.Reflection;
using System.Text;
using System.Xml;
using HtmlAgilityPack;
using PropertyInfo = System.Reflection.PropertyInfo;

namespace ReactWithDotNet.WebSite.HelperApps;

static class HtmlToReactWithDotNetCsharpCodeConverter
{
    static readonly IReadOnlyDictionary<string, string> AttributeRealNameMap = new Dictionary<string, string>
    {
        { "class", "className" },
        { "for", "htmlFor" },
        { "rowspan", "rowSpan" },
        { "colspan", "colSpan" },
        { "cellspacing", "cellSpacing" },
        { "cellpadding", "cellPadding" },
        { "tabindex", "tabIndex" },
        { "preserveaspectratio", "preserveAspectRatio" }
    };

    public static string HtmlToCSharp(string htmlRootNode, bool smartMode)
    {
        if (string.IsNullOrWhiteSpace(htmlRootNode))
        {
            return null;
        }

        var document = new HtmlDocument();

        document.LoadHtml(htmlRootNode.Trim());

        return ToCSharpCode(ToCSharpCode(document.DocumentNode.FirstChild,smartMode));
    }

    static string CamelCase(string str)
    {
        if (str == null)
        {
            return null;
        }

        if (str.IndexOf('-') > 0)
        {
            return string.Join(string.Empty, str.Split("-").Select(CamelCase));
        }

        if (str == "lowercase")
        {
            return "LowerCase";
        }

        if (str == "uppercase")
        {
            return "UpperCase";
        }

        return char.ToUpper(str[0], new CultureInfo("en-US")) + str.Substring(1);
    }

    static string ConvertToCSharpString(string value)
    {
        if (value == null)
        {
            return null;
        }

        if (value.Contains('\u2028'))
        {
            value = value.Replace('\u2028', '\n');
        }

        if (value.Contains('\n'))
        {
            value = value.Replace("\"", "\"\"");
        }
        else
        {
            value = value.Replace("\"", "\\\"");
        }

        if (value.Contains("&nbsp;"))
        {
            return string.Join(", nbsp, ", value.Split(new[] { "&nbsp;" }, StringSplitOptions.RemoveEmptyEntries).Select(ConvertToCSharpString));
        }

        value = '"' + value + '"';

        if (value.Contains('\n'))
        {
            value = '@' + value;
        }

        return value;
    }

    static IReadOnlyList<T> Fold<T>(this IEnumerable<IEnumerable<T>> enumerable)
    {
        return enumerable.Aggregate(new List<T>(), (list, item) =>
        {
            list.AddRange(item);
            return list;
        });
    }

    static string GetName(this HtmlAttribute htmlAttribute)
    {
        var name = htmlAttribute.Name;

        if (htmlAttribute.OriginalName != name)
        {
            if (name.All(char.IsLower) && htmlAttribute.OriginalName.Any(char.IsUpper))
            {
                name = htmlAttribute.OriginalName;
            }
        }

        if (AttributeRealNameMap.ContainsKey(name))
        {
            return AttributeRealNameMap[name];
        }

        if (name.Contains(":"))
        {
            var parts = name.Split(":");

            return parts[0] + char.ToUpper(parts[1][0]) + parts[1].Substring(1);
        }

        return name;
    }

    static string GetTagName(this HtmlAttribute htmlAttribute)
    {
        return htmlAttribute.OwnerNode.Name;
    }

    static void Insert(this HtmlAttributeCollection htmlAttributeCollection, int index, string name, string value)
    {
        htmlAttributeCollection.Add(name, value);

        var attribute = htmlAttributeCollection[name];

        htmlAttributeCollection.Remove(attribute);

        htmlAttributeCollection.Insert(index, attribute);
    }

    static IReadOnlyList<HtmlAttribute> RemoveAll(this HtmlAttributeCollection htmlAttributeCollection, Func<HtmlAttribute, bool> match)
    {
        var items = htmlAttributeCollection.Where(match).ToList();

        foreach (var htmlAttribute in items)
        {
            htmlAttributeCollection.Remove(htmlAttribute);
        }

        return items;
    }

    static void RemoveAll(this HtmlNodeCollection htmlNodeCollection, Func<HtmlNode, bool> match)
    {
        var nodes = htmlNodeCollection.Where(match).ToList();

        foreach (var node in nodes)
        {
            htmlNodeCollection.Remove(node);
        }
    }

    /// <summary>
    ///     Removes from end.
    /// </summary>
    static string RemoveFromEnd(this string data, string value, StringComparison comparison = StringComparison.OrdinalIgnoreCase)
    {
        if (data.EndsWith(value, comparison))
        {
            return data.Substring(0, data.Length - value.Length);
        }

        return data;
    }

    /// <summary>
    ///     Removes value from start of str
    /// </summary>
    static string RemoveFromStart(this string data, string value, StringComparison comparison = StringComparison.OrdinalIgnoreCase)
    {
        if (data == null)
        {
            return null;
        }

        if (data.StartsWith(value, comparison))
        {
            return data.Substring(value.Length, data.Length - value.Length);
        }

        return data;
    }

    static string ToCSharpCode(IEnumerable<string> lines)
    {
        var sb = new StringBuilder();

        var padding = 0;

        foreach (var line in lines)
        {
            var paddingAsString = "".PadRight(padding * 4, ' ');
            if (line == "{")
            {
                sb.AppendLine(paddingAsString + line);
                padding++;
                continue;
            }

            if (line == "}" || line == "},")
            {
                if (padding == 0)
                {
                    throw new InvalidOperationException("Padding is already zero.");
                }

                padding--;
                paddingAsString = "".PadRight(padding * 4, ' ');
                sb.AppendLine(paddingAsString + line);

                continue;
            }

            sb.AppendLine(paddingAsString + line);
        }

        return sb.ToString().Trim();
    }

    static List<string> ToCSharpCode(HtmlNode htmlNode, bool smartMode)
    {
        var modifiers = new List<string>();

        var htmlNodeName = htmlNode.OriginalName;
        if (htmlNodeName == "clippath")
        {
            htmlNodeName = "clipPath";
        }

        if (htmlNodeName == "#text")
        {
            if (string.IsNullOrWhiteSpace(htmlNode.InnerText))
            {
                return Enumerable.Empty<string>().ToList();
            }

            if (htmlNode.InnerText == "&nbsp;")
            {
                return new List<string> { "nbsp" };
            }

            return new List<string> { ConvertToCSharpString(htmlNode.InnerText) };
        }

        if (htmlNodeName == "br")
        {
            return new List<string> { "br" };
        }

        Style style = null;

        // grab style attribute
        {
            var styleAttribute = htmlNode.Attributes["style"];
            if (styleAttribute != null)
            {
                if (!string.IsNullOrWhiteSpace(styleAttribute.Value))
                {
                    style = Style.ParseCss(styleAttribute.Value);
                }

                htmlNode.Attributes.Remove("style");
            }
        }

        string styleAsCode()
        {
            return $"new Style {{ {string.Join(", ", style.ToDictionary().Select(kv => kv.Key + " = \"" + kv.Value + "\""))} }}";
        }

        // aria-*
        {
            static bool isAriaAttribute(HtmlAttribute htmlAttribute)
            {
                return htmlAttribute.Name.StartsWith("aria-", StringComparison.OrdinalIgnoreCase);
            }

            static string toAriaModifier(HtmlAttribute htmlAttribute)
            {
                return $"Aria(\"{htmlAttribute.Name.RemoveFromStart("aria-")}\", \"{htmlAttribute.Value}\")";
            }

            modifiers.AddRange(htmlNode.Attributes.RemoveAll(isAriaAttribute).Select(toAriaModifier));
        }

        // data-*
        {
            static bool isDataAttribute(HtmlAttribute htmlAttribute)
            {
                return htmlAttribute.Name.StartsWith("data-", StringComparison.OrdinalIgnoreCase);
            }

            static string toDataModifier(HtmlAttribute htmlAttribute)
            {
                return $"Data(\"{htmlAttribute.Name.RemoveFromStart("data-")}\", \"{htmlAttribute.Value}\")";
            }

            modifiers.AddRange(htmlNode.Attributes.RemoveAll(isDataAttribute).Select(toDataModifier));
        }

        // remove svg.xmlns
        {
            if (htmlNode.Name == "svg")
            {
                if (htmlNode.Attributes.Contains("xmlns") && htmlNode.Attributes["xmlns"].Value == "http://www.w3.org/2000/svg")
                {
                    htmlNode.Attributes.Remove("xmlns");
                }
            }

            if (htmlNode.Name == "svg" || htmlNode.Name == "path")
            {
                bool isStyleAttribute(HtmlAttribute htmlAttribute)
                {
                    if (TryFindProperty(htmlNode.Name, htmlAttribute.Name) is null)
                    {
                        if (typeof(Style).GetProperty(htmlAttribute.Name.Replace("-", ""), BindingFlags.Public | BindingFlags.Instance | BindingFlags.IgnoreCase) is not null)
                        {
                            return true;
                        }
                    }

                    return false;
                }

                foreach (var htmlAttribute in htmlNode.Attributes.RemoveAll(isStyleAttribute))
                {
                    style[htmlAttribute.Name] = htmlAttribute.Value;
                }
            }
        }

        // innerText
        {
            if (htmlNode.ChildNodes.Count == 1 && htmlNode.ChildNodes[0].Name == "#text")
            {
                var text = htmlNode.ChildNodes[0].InnerText.Trim();
                
                if (string.IsNullOrWhiteSpace(text) is false)
                {
                    if (smartMode)
                    {
                        modifiers.Insert(0, '"' + text + '"');
                    }
                    else //if (htmlNode.Attributes.Any())
                    {
                        htmlNode.Attributes.Insert(0, "text", text);   
                    }
                }
                
                htmlNode.ChildNodes.RemoveAt(0);
            }
        }

        // Flex
        {
            if (htmlNodeName == "div")
            {
                if (style is not null)
                {
                    // c o l u m n s
                    if (style.display == "inline-flex" &&
                        style.flexDirection == "column" &&
                        style.justifyContent == "center" &&
                        style.alignItems == "center")
                    {
                        htmlNodeName  = "InlineFlexColumnCentered";
                        style.display = style.flexDirection = style.justifyContent = style.alignItems = null;
                    }

                    if (style.display == "flex" &&
                        style.flexDirection == "column" &&
                        style.justifyContent == "center" &&
                        style.alignItems == "center")
                    {
                        htmlNodeName  = "FlexColumnCentered";
                        style.display = style.flexDirection = style.justifyContent = style.alignItems = null;
                    }

                    if (style.display == "flex" && style.flexDirection == "column")
                    {
                        htmlNodeName  = "FlexColumn";
                        style.display = style.flexDirection = null;
                    }

                    // r o w
                    if (style.display == "inline-flex" &&
                        (style.flexDirection is null || style.flexDirection == "row") &&
                        style.justifyContent == "center" &&
                        style.alignItems == "center")
                    {
                        htmlNodeName  = "InlineFlexRowCentered";
                        style.display = style.flexDirection = style.justifyContent = style.alignItems = null;
                    }

                    if (style.display == "flex" &&
                        (style.flexDirection is null || style.flexDirection == "row") &&
                        style.justifyContent == "center" &&
                        style.alignItems == "center")
                    {
                        htmlNodeName  = "FlexRowCentered";
                        style.display = style.flexDirection = style.justifyContent = style.alignItems = null;
                    }

                    if (style.display == "flex" && style.flexDirection == "row")
                    {
                        htmlNodeName  = "FlexRow";
                        style.display = style.flexDirection = null;
                    }
                }
            }
        }

        // border
        {
            if (style is not null)
            {
                foreach (var prefix in new[] { "borderTop", "borderRight", "borderLeft", "borderBottom" })
                {
                    var xStyle = style[$"{prefix}Style"];
                    var xWidth = style[$"{prefix}Width"];
                    var xColor = style[$"{prefix}Color"];

                    if (style[prefix] is null)
                    {
                        if (string.IsNullOrWhiteSpace(xStyle) is false &&
                            string.IsNullOrWhiteSpace(xWidth) is false &&
                            string.IsNullOrWhiteSpace(xColor) is false)
                        {
                            style[prefix] = $"{xWidth} {xStyle} {xColor}";

                            style[$"{prefix}Style"] = style[$"{prefix}Width"] = style[$"{prefix}Color"] = null;
                        }

                        if (string.IsNullOrWhiteSpace(xStyle) is false &&
                            string.IsNullOrWhiteSpace(xWidth) is false &&
                            string.IsNullOrWhiteSpace(xColor))
                        {
                            style[prefix] = $"{xWidth} {xStyle}";

                            style[$"{prefix}Style"] = style[$"{prefix}Width"] = style[$"{prefix}Color"] = null;
                        }
                    }
                }
            }
        }

        // remove comments
        {
            htmlNode.ChildNodes.RemoveAll(childNode => childNode.Name == "#comment");
        }

        if (smartMode && style is not null)
        {
            modifiers.AddRange(htmlNode.Attributes.Select(ToModifier));
            
            ((ICollection<HtmlAttribute>)htmlNode.Attributes).Clear();
            modifiers.AddRange(style.ToDictionary().Select(p => TryConvertToModifier_From_Mixin_Extension(p.Key, p.Value)).Where(x => x.success).Select(x => x.modifierCode));

            style = null;
        }
        
        bool canBeExportInOneLine()
        {
            if (htmlNode.Attributes.Contains("text"))
            {
                return false;
            }

            if (style is not null)
            {
                if (canStyleExportInOneLine(style) is false)
                {
                    return false;
                }
            }

            if (htmlNode.ChildNodes.Count == 0 && smartMode && modifiers.Count > 3)
            {
                return false;
            }

            if (htmlNode.Attributes.Count > 3)
            {
                return false;
            }

            return true;
        }

        static bool canStyleExportInOneLine(Style style)
        {
            return style.ToDictionary().Count <= 3;
        }

        if (htmlNode.ChildNodes.Count == 0)
        {
            List<string> attributeToString(HtmlAttribute attribute)
            {
                if (attribute.Name == "style" && style is not null)
                {
                    if (canStyleExportInOneLine(style))
                    {
                        if (smartMode)
                        {
                            return [string.Join(", ",style.ToDictionary().Select(p=>TryConvertToModifier_From_Mixin_Extension(p.Key,p.Value)).Where(x=>x.success).Select(x=>x.modifierCode))];
                        }
                        
                        return new List<string> { $"style = {{ {string.Join(", ", style.ToDictionary().Select(kv => kv.Key + " = \"" + kv.Value + "\""))} }}" };
                    }

                    var returnList = new List<string>
                    {
                        "style =",
                        "{"
                    };

                    returnList.AddRange(style.ToDictionary().Select(toLine));

                    returnList[^1] = returnList[^1].RemoveFromEnd(",");

                    returnList.Add("}");

                    return returnList;

                    static string toLine(KeyValuePair<string, string> kv)
                    {
                        return kv.Key + " = \"" + kv.Value + "\",";
                    }
                }

                var propertyInfo = TryFindProperty(attribute.GetTagName(), attribute.GetName());
                if (propertyInfo is not null)
                {
                    if (smartMode)
                    {
                        return [ToModifier(attribute)];
                    }
                    
                    return new List<string> { $"{propertyInfo.Name} = \"{attribute.Value}\"" };
                }

                if (canBeExportInOneLine())
                {
                    return new List<string> { $"/* {attribute.GetName()} = \"{attribute.Value}\"*/" };
                }

                return new List<string> { $"// {attribute.GetName()} = \"{attribute.Value}\"" };
            }

            if (style is not null)
            {
                htmlNode.Attributes.Add("style", "");
            }

            if (canBeExportInOneLine())
            {
                if (smartMode && modifiers.Count > 0)
                {
                    return [$"new {htmlNodeName} {{ {string.Join(", ", modifiers)} }}"];
                }
                
                var sb = new StringBuilder();
                sb.Append($"new {htmlNodeName}");

                if (modifiers.Count == 0 && htmlNode.Attributes.Count == 0)
                {
                    sb.Append("()");
                    return new List<string>
                    {
                        sb.ToString()
                    };
                }
                
                if (modifiers.Count > 0)
                {
                    sb.Append("(");
                    sb.Append(string.Join(", ", modifiers));
                    sb.Append(")");
                }

                if (htmlNode.Attributes.Count > 0)
                {
                    sb.Append(" { ");
                    sb.Append(string.Join(", ", htmlNode.Attributes.Select(attributeToString).Fold()));
                    sb.Append(" }");
                }

                return new List<string>
                {
                    sb.ToString()
                };
            }

            // multiline
            {

                if (smartMode)
                {
                    if (modifiers.Count > 0 && htmlNode.Attributes.Count  == 0)
                    {
                        var lines = new List<string>
                        {
                            $"new {htmlNodeName}",
                            "{"
                        };

                        foreach (var modifier in modifiers)
                        {
                            lines.Add(modifier);
                            
                            lines[^1] += ",";
                        }

                        lines[^1] = lines[^1].RemoveFromEnd(",");
                        lines.Add("}");

                        return lines;
                    }
                }
                
                var sb = new StringBuilder();
                sb.Append($"new {htmlNodeName}");

                if (modifiers.Count > 0)
                {
                    sb.Append("(");
                    sb.Append(string.Join(", ", modifiers));
                    sb.Append(")");
                }

                {
                    var lines = new List<string>
                    {
                        sb.ToString()
                    };

                    if (htmlNode.Attributes.Count > 0)
                    {
                        lines.Add("{");

                        foreach (var list in htmlNode.Attributes.Select(attributeToString))
                        {
                            if (list.Count > 0)
                            {
                                lines.AddRange(list);
                            }
                            else
                            {
                                lines.Add(list[0]);
                            }

                            lines[^1] += ",";
                        }

                        lines[^1] = lines[^1].RemoveFromEnd(",");
                        lines.Add("}");
                    }

                    return lines;
                }
            }
        }

        foreach (var htmlAttribute in htmlNode.Attributes)
        {
            modifiers.Add(ToModifier(htmlAttribute));
        }

        if (style is not null)
        {
            modifiers.Add(styleAsCode());
        }

        if (htmlNode.ChildNodes.Count == 1 && htmlNode.ChildNodes[0].Name == "#text")
        {
            if (htmlNode.Attributes.Count == 0 && style is null)
            {
                return new List<string> { $"({htmlNodeName})" + ConvertToCSharpString(htmlNode.ChildNodes[0].InnerText) };
            }

            return new List<string>
            {
                // one line
                $"new {htmlNodeName}({string.Join(", ", modifiers)})",
                "{",
                ConvertToCSharpString(htmlNode.ChildNodes[0].InnerText),
                "}"
            };
        }

        // multi line
        {
            var partConstructor = "";
            if (modifiers.Count > 0)
            {
                partConstructor = $"({string.Join(", ", modifiers)})";
            }

            var lines = new List<string>
            {
                $"new {htmlNodeName}{partConstructor}",
                "{"
            };

            foreach (var items in htmlNode.ChildNodes.Select(x=>ToCSharpCode(x,smartMode)))
            {
                if (items.Count > 0)
                {
                    items[^1] += ",";
                }

                lines.AddRange(items);
            }

            if (lines[^1].EndsWith(",", StringComparison.OrdinalIgnoreCase))
            {
                lines[^1] = lines[^1].Remove(lines[^1].Length - 1);
            }

            lines.Add("}");

            return lines;
        }
    }

   
    
    static string ToModifier(HtmlAttribute htmlAttribute)
    {
        return TryConvertToModifier(htmlAttribute).modifierCode;
    }
    
    static (bool success, string modifierCode) TryConvertToModifier_From_Mixin_Extension(string name, string value)
    {
        var success = (string modifierCode) => (true, modifierCode);

        value ??= string.Empty;
        
        if (name == "target" && value == "_blank")
        {
            return success("TargetBlank");
        }

        var modifierFullName = $"{CamelCase(name)}{CamelCase(value)}";

        if (typeof(Mixin).GetProperty(modifierFullName) is not null)
        {
            return success(modifierFullName);
        }

        if (typeof(Mixin).GetMethod(CamelCase(name), [typeof(string)] ) is not null)
        {
            if (typeof(Mixin).GetMethod(CamelCase(name), [typeof(double)] ) is not null && 
                value.EndsWith("px",StringComparison.OrdinalIgnoreCase) == true)
            {
                return success($"{CamelCase(name)}({value.RemoveFromEnd("px")})");
            }

            if (value.StartsWith("rgb(", StringComparison.OrdinalIgnoreCase))
            {
                return success($"{CamelCase(name)}({value})");
            }
            
            return success($"{CamelCase(name)}(\"{value}\")");
        }

        return default;
    }
    
    static (bool success, string modifierCode) TryConvertToModifier(HtmlAttribute htmlAttribute)
    {
        
        var name = htmlAttribute.GetName();
        var value = htmlAttribute.Value;
        var tagName = htmlAttribute.OwnerNode.Name;
        
        var success = (string modifierCode) => (true, modifierCode);


        var response = TryConvertToModifier_From_Mixin_Extension(name, value);
        if (response.success)
        {
            return response;
        }
        
        if (name == "focusable" && tagName == "svg")
        {
            return success($"svg.Focusable(\"{value}\")");
        }

        if (name == "type" && tagName == "button")
        {
            return success($"button.Type(\"{value}\")");
        }

        if (name.Equals("viewbox", StringComparison.OrdinalIgnoreCase) && tagName == "svg")
        {
            return success($"ViewBox(\"{value}\")");
        }

        var propertyInfo = TryFindProperty(tagName, name);
        if (propertyInfo is not null)
        {
            if (propertyInfo.PropertyType == typeof(double?))
            {
                if (double.TryParse(value, out var valueAsDouble))
                {
                    return success($"{tagName}.{UpperCaseFirstChar(propertyInfo.Name)}({valueAsDouble})");
                }
            }

            if (propertyInfo.PropertyType == typeof(int?))
            {
                if (int.TryParse(value, out var valueAsInt32))
                {
                    return success($"{tagName}.{UpperCaseFirstChar(propertyInfo.Name)}({valueAsInt32})");
                }
            }

            return success($"{tagName}.{UpperCaseFirstChar(propertyInfo.Name)}(\"{value}\")");
        }

        return (success: false, modifierCode:$"null/* {tagName}.{name} = \"{value}\"*/");

        static string UpperCaseFirstChar(string str)
        {
            return char.ToUpper(str[0], new CultureInfo("en-US")) + str.Substring(1);
        }
    }

    static PropertyInfo TryFindProperty(string htmlTagName, string attributeName)
    {
        var propertyName = string.Join(string.Empty, attributeName.Split(":-".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()));

        return TryFindTypeOfHtmlTag(htmlTagName)?.GetProperty(propertyName, BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance);
    }

    static Type TryFindTypeOfHtmlTag(string htmlTagName)
    {
        return typeof(div).Assembly.GetType(nameof(ReactWithDotNet) + "." + htmlTagName, false, true);
    }
}