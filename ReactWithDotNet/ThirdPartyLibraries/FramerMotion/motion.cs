﻿
namespace ReactWithDotNet.ThirdPartyLibraries.FramerMotion;

public static class motion 
{
    public sealed class div : ElementBase
    {
        [ReactProp]
        [ReactTransformValueInClient(Core__ReplaceNullWhenEmpty)]
        public dynamic animate { get; } = new ExpandoObject();

        [ReactProp]
        [ReactTransformValueInClient(Core__ReplaceNullWhenEmpty)]
        public dynamic initial { get; } = new ExpandoObject();

        [ReactProp]
        [ReactTransformValueInClient(Core__ReplaceNullWhenEmpty)]
        public  dynamic transition { get; } = new ExpandoObject();
    
    
        [ReactProp]
        [ReactTransformValueInClient(Core__ReplaceNullWhenEmpty)]
        public dynamic exit { get; } = new ExpandoObject();
    
        [ReactProp]
        [ReactTransformValueInClient(Core__ReplaceNullWhenEmpty)]
        public dynamic whileHover { get; } = new ExpandoObject();
        
        public static IModifier Modify(Action<div> modifyAction) => CreateThirdPartyReactComponentModifier(modifyAction);
    }
    
    public sealed class button : ElementBase
    {
        [ReactProp]
        [ReactTransformValueInClient(Core__ReplaceNullWhenEmpty)]
        public dynamic animate { get; } = new ExpandoObject();

        [ReactProp]
        [ReactTransformValueInClient(Core__ReplaceNullWhenEmpty)]
        public dynamic initial { get; } = new ExpandoObject();

        [ReactProp]
        [ReactTransformValueInClient(Core__ReplaceNullWhenEmpty)]
        public  dynamic transition { get; } = new ExpandoObject();
    
    
        [ReactProp]
        [ReactTransformValueInClient(Core__ReplaceNullWhenEmpty)]
        public dynamic exit { get; } = new ExpandoObject();
    
        [ReactProp]
        [ReactTransformValueInClient(Core__ReplaceNullWhenEmpty)]
        public dynamic whileHover { get; } = new ExpandoObject();
    }
}