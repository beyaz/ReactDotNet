using ReactWithDotNet.TypeScriptCodeAnalyzer;
using System.Globalization;
using ReactWithDotNet.Tokenizing;
using static ReactWithDotNet.TypeScriptCodeAnalyzer.TokenMatch;

namespace ReactWithDotNet.Exporting;

static class Exporter
{
    public static void ExportToCSharpFile(ExportInput input)
    {
        var code = CalculateCSharpFileContentLines(input).GetValue().ToCSharpCode();

        const string projectFolder = @"C:\github\ReactWithDotNet\ReactWithDotNet\ThirdPartyLibraries";

        WriteAllText($@"{projectFolder}{input.OutputFileLocation}{input.ClassName}.cs", code);
    }

    static (bool hasMatch, string dotNetType) TryMatchDotNetOneParameterAction(TsMemberInfo memberInfo)
    {
        var tokens = memberInfo.RemainingPart?.Where(IsNotSpace).ToList() ?? new List<Token>();

        string parameterType = null;
        
        if (tokens.FullMatch("(", "event", ":", OnTokenMatched(t=> parameterType = t.value), ")", ":", "void"))
        {
            return (hasMatch: true, dotNetType: $"Action<{parameterType}>");
        }

        return default;
    }

    static Result<string> ResolveDotNetTypeName(IReadOnlyList<Token> tokens,int startIndex, int endIndex)
    {
        
        if (endIndex - startIndex == 0)
        {
            var name = tokens[startIndex].value;

            if (name.Equals("string", StringComparison.OrdinalIgnoreCase))
            {
                return "string";
            }

            if (name.Equals("number", StringComparison.OrdinalIgnoreCase))
            {
                return "double?";
            }

            if (name.Equals("boolean", StringComparison.OrdinalIgnoreCase))
            {
                return "bool?";
            }

            if (name.Equals("dynamic", StringComparison.OrdinalIgnoreCase))
            {
                return "dynamic";
            }
        }
        
        // is object
        if (tokens[startIndex].tokenType == TokenType.LeftCurlyBracket && tokens[endIndex].tokenType == TokenType.RightCurlyBracket)
        {
            return "dynamic";
        }

        if (tokens.StartsWith(startIndex, "Partial<"))
        {
            return "dynamic";
        }

        if (tokens.StartsWith(startIndex,"React.ReactNode"))
        {
            return "Element";
        }
        if (tokens.StartsWith(startIndex,"React.SyntheticEvent"))
        {
            return "MouseEvent";
        }
        
        if (tokens.StartsWith(startIndex,"OverridableStringUnion"))
        {
            return "string";
        }

        if (tokens.FullMatch("string | number"))
        {
            return "int?";
        }

        if (tokens.FullMatch("string | undefined"))
        {
            return "string";
        }
        
        if (tokens.FullMatch("number | undefined"))
        {
            return "double?";
        }

        if (tokens.FullMatch("boolean | undefined"))
        {
            return "bool?";
        }

        if (tokens.FullMatch("React.CSSProperties | undefined"))
        {
            return "Style";
        }
        

        var (hasRead, tsTypeReference, _) = Ast.TryReadUnionTypeReference(tokens, startIndex);
        if (hasRead)
        {
            if (tsTypeReference.UnionTypes?.All(t => t.IsStringValue || t.Name == "undefined") == true)
            {
                return "string";
            }

            return "object";
        }
        
        return None;
    }

    static (bool hasMatch, string dotNetType) ResolveDotNetTypeName(TsMemberInfo memberInfo)
    {
        var tokens = memberInfo.RemainingPart?.Where(IsNotSpace).Where(IsNotColon).ToList() ?? new List<Token>();
        if (tokens.Count <= 0)
        {
            return default;
        }

        return ResolveDotNetTypeName(tokens,0, tokens.Count-1).Or(() => TryMatchDotNetOneParameterAction(memberInfo)).Or(()=>default);
    }

    static Result<IReadOnlyList<(string dotNetType, string parameterName)>> ResolveDotNetTypeNames(IReadOnlyList<TsMethodParameterInfo> parameters)
    {
        var items = new List < (string dotNetType, string parameterName)>();

        foreach (var parameter in parameters)
        {
            var response = resolveDotNetTypeName(parameter.TypeReference);
            if (response.Fail)
            {
                return response.FailInfo;
            }
            
            items.Add((dotNetType: response.Value, parameter.ParameterName));
        }

        return items;

        static Result<string> resolveDotNetTypeName(TsTypeReference reference)
        {
            if (reference.Name == "React.ChangeEvent")
            {
                return nameof(ChangeEvent);
            }
            
            return ResolveDotNetTypeName(reference.Tokens, reference.StartIndex, reference.EndIndex);
        }
    }
    static IReadOnlyList<string> AsCSharpMember(ExportInput input, TsMemberInfo memberInfo)
    {
        var lines = new List<string>();

        if (memberInfo.Comment is not null)
        {
            lines.AddRange(AsCSharpComment(memberInfo.Comment));
        }

        if (isVoidFunction())
        {
            var functionParameters = Ast.TryReadFunctionParameters(memberInfo.RemainingPart, 1).To(x=>x.parameters);
            if (functionParameters.Success)
            {
                var prm = ResolveDotNetTypeNames(functionParameters.Value);
                if (prm.Success)
                {
                    lines.Add("[ReactProp]");
                    
                    var dotNetType = $"Func<{string.Join(", ",prm.Value.Select(p=>$"{p.dotNetType}"))}, Task>";

                    var memberName = memberInfo.Name;
                    
                    lines.Add($"public {dotNetType} {memberName} {{ get; set; }}");
                    
                    
                    //lines.Add(string.Empty);
                    //lines.AddRange(AsCSharpComment(memberInfo.Comment));
                    //lines.Add($"public static Modifier {UpperCaseFirstChar(memberName.RemoveFromStart("@"))}({dotNetType} value) => CreateThirdPartyReactComponentModifier<{input.ClassName}>(x => x.{memberName} = value);");
                    
                    return lines;
                }
            }
        }
        
        if (isReturnsReactNodeFunction())
        {
            var functionParameters = Ast.TryReadFunctionParameters(memberInfo.RemainingPart, 1).To(x=>x.parameters);
            if (!functionParameters.Success)
            {
                return lines;
            }
            
            var prm = ResolveDotNetTypeNames(functionParameters.Value);
            if (!prm.Success)
            {
                return lines;
            }
            
            

            var memberName = memberInfo.Name;
            
            var dotNetType = $"{memberName}Delegate";
            
            lines.Add($"public delegate Element {dotNetType}({string.Join(", ", prm.Value.Select(p=>$"{p.dotNetType} {getParameterName(p.parameterName)}"))});");
            lines.Add(string.Empty);
            
            lines.Add("[ReactProp]");
            lines.Add($"public {dotNetType} {memberName} {{ get; set; }}");
                    
                    
            //lines.Add(string.Empty);
            //lines.AddRange(AsCSharpComment(memberInfo.Comment));
            //lines.Add($"public static Modifier {UpperCaseFirstChar(memberName.RemoveFromStart("@"))}({dotNetType} value) => CreateThirdPartyReactComponentModifier<{input.ClassName}>(x => x.{memberName} = value);");
                    
            return lines;
        }

        {
            if (!input.PropToDotNetTypeMap.TryGetValue($"{input.NamespaceName} > {input.ClassName} > {memberInfo.Name}", out var dotNetType))
            {
                if (!input.PropToDotNetTypeMap.TryGetValue($"{input.NamespaceName} > * > {memberInfo.Name}", out dotNetType))
                {
                    var matchResponse = ResolveDotNetTypeName(memberInfo);
                    if (matchResponse.hasMatch)
                    {
                        dotNetType = matchResponse.dotNetType;
                    }
                }
            }

            if (dotNetType is null)
            {
                return lines;
            }
        
        
            var memberName = memberInfo.Name;
            if (memberName == "checked")
            {
                memberName = "@" + memberName;
            }

            lines.Add("[ReactProp]");

            if (dotNetType == "dynamic")
            {
                lines.Add("[ReactTransformValueInServerSide(typeof(DoNotSendToClientWhenEmpty))]");
                lines.Add($"public dynamic {memberInfo.Name} {{ get; }} = new ExpandoObject();");
                return lines;
            }

            if (dotNetType == "init_only_style_map")
            {
                lines.Add("[ReactTransformValueInServerSide(typeof(convert_mui_style_map_to_class_map))]");
                lines.Add($"public Dictionary<string, Style> {memberInfo.Name} {{ get; }} = new ();");
                return lines;
            }

            if (dotNetType == "Style")
            {
                lines.Add("[ReactTransformValueInServerSide(typeof(DoNotSendToClientWhenStyleEmpty))]");
                lines.Add($"public Style {memberInfo.Name} {{ get; }} = new ();");
                return lines;
            }

            lines.Add($"public {dotNetType} {memberName} {{ get; set; }}");
        
            //lines.Add(string.Empty);
        
            //if (memberInfo.Comment is not null)
            //{
            //    lines.AddRange(AsCSharpComment(memberInfo.Comment));
            //}
            //lines.Add($"public {(memberName == "type" ? "new ": "")}static Modifier {UpperCaseFirstChar(memberName.RemoveFromStart("@"))}({dotNetType} value) => CreateThirdPartyReactComponentModifier<{input.ClassName}>(x => x.{memberName} = value);");

        }
        
        return lines;

        bool isVoidFunction()
        {
            if (memberInfo.RemainingPart.StartsWith(0,":("))
            {
                if (memberInfo.RemainingPart.EndsWith("=> void"))
                {
                    
                    return true;
                }
            }
            
            return false;
        }
        
        bool isReturnsReactNodeFunction()
        {
            if (memberInfo.RemainingPart.StartsWith(0,":("))
            {
                if (memberInfo.RemainingPart.EndsWith("=> React.ReactNode"))
                {
                    
                    return true;
                }
            }
            
            return false;
        }

        static string UpperCaseFirstChar(string str)
        {
            return char.ToUpper(str[0], new CultureInfo("en-US")) + str.Substring(1);
        }
        static string getParameterName(string name)
        {
            if (name == "params")
            {
                return "@params";
            }

            return name;
        }
    }

    public static Result<TsMemberInfo> ParseMemberTokens(IReadOnlyList<Token> tokens)
    {
        tokens = tokens.Where(t => t.tokenType != TokenType.Space).ToList();

        var i = 0;

        string comment = null;

        if (tokens[i].tokenType == TokenType.Comment)
        {
            comment = tokens[i].value;

            i++;
        }

        while (tokens[i].tokenType == TokenType.Comment)
        {
            i++;
        }

        if (tokens[i].tokenType == TokenType.AlfaNumeric)
        {
            var name = tokens[i].value;

            i++;

            if (tokens[i].tokenType == TokenType.QuestionMark)
            {
                i++;
            }

            return new TsMemberInfo { Comment = comment, Name = name, RemainingPart = tokens.ToList().GetRange(i, tokens.Count - i) };
        }
        
        if (tokens[i].tokenType == TokenType.QuotedString)
        {
            var name = tokens[i].value;

            i++;

            if (tokens[i].tokenType == TokenType.QuestionMark)
            {
                i++;
            }
            
            return new TsMemberInfo { Comment = comment, Name = KebabToCamelCase(name), RemainingPart = tokens.ToList().GetRange(i, tokens.Count - i) };
        }

        return Fail("Member not resolved.");
        
        static string KebabToCamelCase(string kebab)
        {
            if (string.IsNullOrEmpty(kebab))
                return kebab;

            return string.Concat(kebab
                                     .Split('-')
                                     .Select((word, index) => index == 0 
                                                 ? word.ToLower() 
                                                 : char.ToUpper(word[0]) + word.Substring(1).ToLower()));
        }

    }

    static (Exception exception, IReadOnlyList<string> lines) CalculateCSharpFileContentLines(ExportInput input)
    {
        var (hasRead, _, tokens) = Lexer.ParseTokens(input.DefinitionTsCode, 0);

        if (!hasRead)
        {
            return (null, new List<string>());
        }

        var (isFound, _, indexOfLastMatchedToken) = Lexer.FindMatch(tokens, 0, Lexer.ParseTokens(input.StartFrom, 0).tokens);
        if (!isFound)
        {
            return (null, new List<string>());
        }

        (hasRead, var members, _) = Ast.TryReadMembers(tokens, indexOfLastMatchedToken);
        if (!hasRead)
        {
            return (null, new List<string>());
        }
        
        var lines = new List<string>
        {
            "// auto generated code (do not edit manually)",
            string.Empty,
            $"namespace ReactWithDotNet.ThirdPartyLibraries.{input.NamespaceName};",
            string.Empty
        };

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
            if (input.SkipMembers?.Contains(tsMemberInfo.Name) == true)
            {
                continue;
            }

            if (!isFirstMember)
            {
                lines.Add(string.Empty);
            }

            isFirstMember = false;

            lines.AddRange(AsCSharpMember(input, tsMemberInfo));
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

            lines.Add(string.Empty);
            
            lines.Add($"public {input.ClassName}(){{ }}");
            lines.Add(string.Empty);
            lines.Add($"public {input.ClassName}(params Action<{input.ClassName}>[] modifiers) => modifiers.ApplyAll(Add);");
            lines.Add(string.Empty);
            lines.Add($"public {input.ClassName}(StyleModifier styleModifier, params Action<{input.ClassName}>[] modifiers)");
            lines.Add("{");
            lines.Add("Add(styleModifier);");
            lines.Add("modifiers.ApplyAll(Add);");
            lines.Add("}");
            lines.Add(string.Empty);
            lines.Add($"public void Add(Action<{input.ClassName}> modify) => modify?.Invoke(this);");
        }

        lines.Add("}");

        return (null, lines);

    }
}