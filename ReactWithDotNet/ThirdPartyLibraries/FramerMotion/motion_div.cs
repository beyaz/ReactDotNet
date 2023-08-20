﻿namespace ReactWithDotNet.ThirdPartyLibraries.FramerMotion;

public sealed class motion_div : ElementBase
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


public sealed class motion : ElementBase
{
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