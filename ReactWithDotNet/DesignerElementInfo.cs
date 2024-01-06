﻿using System.Reflection;

namespace ReactWithDotNet;

public sealed class DesignerComponentInfo
{
    public Type TargetType { get; set; }
    
    public IReadOnlyList<DesignerElementInfo> VisualTree { get; set; }
}

public sealed class DesignerElementInfo
{
    public IReadOnlyList<int> VisualTreePath { get; set; }
    
    public IReadOnlyList<StyleModifier> Modifiers { get; set; }
}

static class DesignerHelper
{
    public static void Override(Element component, Element rootNode)
    {

        Type componentType = component.GetType();
            
        var designerType = componentType.Assembly.GetType("ReactWithDotNet.__designer__.Designer");
        if (designerType == null)
        {
            return;
        }
        

        var getStyleMethodInfo = designerType.GetMethod("GetStyle", BindingFlags.Static | BindingFlags.Public);

        if (getStyleMethodInfo == null)
        {
            throw new MissingMethodException("GetStyle");
        }
        

        var records = (IReadOnlyList<DesignerComponentInfo>)getStyleMethodInfo.Invoke(null, [componentType]);
        if (records == null)
        {
            return;
        }
        
        var record = records.FirstOrDefault(x => x.TargetType == componentType);
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
    
}