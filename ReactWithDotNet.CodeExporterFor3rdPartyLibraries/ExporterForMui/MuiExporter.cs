using System.Text;
using static ReactWithDotNet.TypeScriptCodeAnalyzer.Mixin;

namespace ReactWithDotNet.TypeScriptCodeAnalyzer;

public class MuiExportInput
{
    public string ClassName { get; set; }
    public string DefinitionTsCode { get; set; }
    public IReadOnlyList<string> SkipMembers { get; set; }
    public string StartFrom { get; set; }
    
    public IReadOnlyList<string> ExtraProps { get; set; }
    public bool IsContainer { get; set; }
    
    public string ClassModifier { get; set; } = "sealed";

    public string BaseClassName { get; set; } = "ElementBase";
}

static class MuiExporter
{
    public static void ExportToCSharpFile(MuiExportInput input)
    {
        var  lines = CalculateCSharpFileContentLines(input);

        var sb = new StringBuilder();

        lines.WriteLines(x => sb.AppendLine(x));

        WriteAllText($@"C:\github\ReactWithDotNet\ReactWithDotNet\ThirdPartyLibraries\MUI\Material\{input.ClassName}.cs", sb.ToString());
    }

    static IEnumerable<string> AsCSharpComment(string tsComment)
    {
        if (tsComment is null)
        {
            return Enumerable.Empty<string>();
        }

        var lines = new List<string>();

        var commentLines = tsComment.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);

        lines.Add("/// <summary>");

        var isFirst = true;

        foreach (var commentLine in commentLines)
        {
            var line = commentLine.Trim()
                                  .Trim(Environment.NewLine.ToCharArray())
                                  .RemoveFromStart("/**")
                                  .RemoveFromStart("/*")
                                  .RemoveFromEnd("*/")
                                  .Trim()
                                  .RemoveFromStart("* ")
                                  .Trim();
            if (string.IsNullOrWhiteSpace(line))
            {
                continue;
            }

            if (isFirst)
            {
                isFirst = false;
            }
            else
            {
                lines.Add("///     <br/>");
            }

            if (line.Trim() == "*")
            {
                line = "<br/>";
            }
            
            lines.Add("///     " + line);
        }

        lines.Add("/// </summary>");

        return lines;
    }

    static IReadOnlyList<string> AsCSharpMember(TsMemberInfo memberInfo)
    {
        var lines = new List<string>();

        if (memberInfo.Comment is not null)
        {
            lines.AddRange(AsCSharpComment(memberInfo.Comment));
        }

        if (memberInfo.Name =="sx")
        {
            lines.Add("[ReactProp]");
            lines.Add("[ReactTransformValueInClient(Core__ReplaceNullWhenEmpty)]");
            lines.Add("public dynamic sx { get; } = new ExpandoObject();");

            return lines;
        }

        if (memberInfo.Name == "classes" && memberInfo.PropertyType?.Name == "Partial")
        {
            lines.Add("[ReactProp]");
            lines.Add("[ReactTransformValueInServerSide(typeof(convert_mui_style_map_to_class_map))]");
            lines.Add($"public Dictionary<string, Style> {memberInfo.Name} {{ get; }} = new ();");
            return lines;
        }

        // export as property
        if (memberInfo.PropertyType is not null)
        {
            if (memberInfo.PropertyType.Name== "React.Ref")
            {
                return lines;
            }
            
            var exportAsDynamicObjectMap = AsCSharpType(memberInfo.PropertyType) == "dynamic";
            
            lines.Add("[ReactProp]");

            if (exportAsDynamicObjectMap)
            {
                lines.Add("[ReactTransformValueInServerSide(typeof(DoNotSendToClientWhenEmpty))]");
                lines.Add($"public dynamic {memberInfo.Name} {{ get; }} = new ExpandoObject();");
                return lines;
            }

            var memberName = memberInfo.Name;
            if (memberName == "checked")
            {
                memberName = "@" + memberName;
            }
            
            lines.Add("public " + AsCSharpType(memberInfo.PropertyType) + " " + memberName + " { get; set; }");

            static string AsCSharpType(TsTypeReference tsTypeReference)
            {
                if (tsTypeReference.TokenListAsUnionValues?.Count > 0)
                {
                    return "string";
                }

                

                if (tsTypeReference.TokenListAsObjectMap?.Count > 0)
                {
                    return "dynamic";
                }

                if (tsTypeReference.Name.Equals("string", StringComparison.OrdinalIgnoreCase))
                {
                    return "string";
                }
                if (tsTypeReference.Name.Equals("React.InputHTMLAttributes", StringComparison.OrdinalIgnoreCase))
                {
                    return "string";
                }
                


                if (tsTypeReference.Name.Equals("unknown", StringComparison.OrdinalIgnoreCase))
                {
                    return "string";
                }

                if (tsTypeReference.Name.Equals("OverridableStringUnion", StringComparison.OrdinalIgnoreCase))
                {
                    return "string";
                }

                if (tsTypeReference.Name.Equals("Partial", StringComparison.OrdinalIgnoreCase))
                {
                    return "dynamic";
                }

                if (tsTypeReference.Name.Equals("number", StringComparison.OrdinalIgnoreCase))
                {
                    return "double?";
                }

                if (tsTypeReference.Name.Equals("boolean", StringComparison.OrdinalIgnoreCase))
                {
                    return "bool?";
                }

                if (tsTypeReference.Name.Equals("SxProps", StringComparison.OrdinalIgnoreCase))
                {
                    return "dynamic";
                }

                if (tsTypeReference.Name.Equals("React.ReactNode", StringComparison.OrdinalIgnoreCase))
                {
                    return "Element";
                }

                return tsTypeReference.Name;
            }
        }
       

        return lines;

       
    }

   

    static IReadOnlyList<string> CalculateCSharpFileContentLines(MuiExportInput input)
    {
        var (exception, hasRead, endIndex, tokens) = TsLexer.ParseTokens(input.DefinitionTsCode, 0);
        if (hasRead)
        {
            var (isFound, indexOfLastMatchedToken) = TsParser.FindMatch(tokens, 0, TsLexer.ParseTokens(input.StartFrom, 0).tokens);
            if (isFound)
            {
                (hasRead, var members, var newIndex) = TsParser.TryReadMembers(tokens, indexOfLastMatchedToken);
                if (hasRead)
                {
                    var lines = new List<string>();

                    lines.Add("// auto generated code (do not edit manually)");
                    lines.Add(string.Empty);
                    lines.Add("namespace ReactWithDotNet.ThirdPartyLibraries.MUI.Material;");
                    lines.Add(string.Empty);

                    var inheritPart = " : " + input.BaseClassName;

                    var classModifier = input.ClassModifier;
                    
                    if (classModifier == "partial")
                    {
                        inheritPart = string.Empty;
                    }

                    
                    if (!string.IsNullOrWhiteSpace(classModifier))
                    {
                        classModifier += " ";
                    }

                    lines.Add($"public {classModifier}class {input.ClassName}{inheritPart}");

                    lines.Add("{");

                    var isFirstMember = true;

                    foreach (var tsMemberInfo in members)
                    {
                        if (input.SkipMembers?.Contains(tsMemberInfo.Name)==true)
                        {
                            continue;
                        }

                        if (!isFirstMember)
                        {
                            lines.Add(string.Empty);
                        }

                        isFirstMember = false;

                        lines.AddRange(AsCSharpMember(tsMemberInfo));
                    }

                    if (input.ExtraProps is not null)
                    {
                        foreach (var extraProp in input.ExtraProps)
                        {
                            lines.Add(string.Empty);
                            lines.Add("[ReactProp]");
                            lines.Add($"public {extraProp} {{ get; set; }}");
                        }
                    }

                    if (input.IsContainer)
                    {
                        lines.Add(string.Empty);
                        lines.Add("protected override Element GetSuspenseFallbackElement()");
                        lines.Add("{");
                        lines.Add("return _children?.FirstOrDefault() ?? new ReactWithDotNetSkeleton.Skeleton();");
                        lines.Add("}");
                    }

                    lines.Add("}");

                    return lines;
                }
            }
        }

        return null;
    }
}