﻿using System.Reflection;

namespace ReactWithDotNet;

public sealed class DesignerComponentInfo
{
    public Type TargetType { get; set; }

    public IReadOnlyList<DesignerElementInfo> VisualTree { get; set; }
}

public sealed class DesignerElementInfo
{
    public IReadOnlyList<StyleModifier> Modifiers { get; set; }
    public IReadOnlyList<int> VisualTreePath { get; set; }
}

static class DesignerHelper
{
    public static List<string> ToCsharpCode(IReadOnlyList<StyleModifier> styleModifierList)
    {
        var code = new List<string>();
        
        foreach (var styleModifier in styleModifierList)
        {
            code.AddRange(ToCsharpCode(styleModifier));
        }

        return code;
    }
    public static List<string> ToCsharpCode(StyleModifier styleModifier)
    {
        var code = new List<string>();
        
        var style = new Style();
                
        style.Apply(styleModifier);

        foreach (var (key, value) in style.ToDictionary())
        {
            code.Add($"{key} : {value}");
        }

        return code;

    }
    
    static readonly LinkedList<CacheItem> Cache = new();

    public static DesignerComponentInfo GetComponentInfo(Element component)
    {
        var componentType = component.GetType();

        var records = ReadFromAssembly(componentType.Assembly);
        if (records == null)
        {
            return null;
        }

        return records.FirstOrDefault(x => x.TargetType == componentType);
    }
    
    public static void Override(Element component, Element rootNode)
    {
        var record = GetComponentInfo(component);
        if (record == null)
        {
            return;
        }

        foreach (var item in record.VisualTree)
        {
            var node = rootNode;
            var i = 1;
            var len = item.VisualTreePath.Count;

            while (i < len)
            {
                var offset = item.VisualTreePath[i];

                if (node is null)
                {
                    break;
                }

                node = node._children[offset];

                i++;
            }

            if (i < len)
            {
                break;
            }

            foreach (var styleModifier in item.Modifiers)
            {
                ModifyHelper.ProcessModifier(node, styleModifier);
            }
        }
    }

    static IReadOnlyList<DesignerComponentInfo> ReadFromAssembly(Assembly assembly)
    {
        var cacheKey = assembly.GetName().Name;

        var item = Cache.FirstOrDefault(x => x.assemblyFullName == cacheKey);

        if (item == null)
        {
            item = new(cacheKey, ReadFromAssemblyNoCache(assembly));

            Cache.AddLast(item);
        }

        return item.value;

        static IReadOnlyList<DesignerComponentInfo> ReadFromAssemblyNoCache(Assembly assembly)
        {
            var designerType = assembly.GetType("ReactWithDotNet.__designer__.Designer");
            if (designerType == null)
            {
                return null;
            }

            var componentInformationListPropertyInfo = designerType.GetProperty("ComponentInformationList", BindingFlags.Static | BindingFlags.Public);

            if (componentInformationListPropertyInfo == null)
            {
                throw new MissingMemberException("componentInformationListPropertyInfo");
            }

            return (IReadOnlyList<DesignerComponentInfo>)componentInformationListPropertyInfo.GetValue(null);
        }
    }

    record CacheItem(string assemblyFullName, IReadOnlyList<DesignerComponentInfo> value);
}