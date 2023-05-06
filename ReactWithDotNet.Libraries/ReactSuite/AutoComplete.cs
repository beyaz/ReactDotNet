﻿namespace ReactWithDotNet.Libraries.ReactSuite;

public sealed class AutoComplete : ElementBase
{
    [ReactProp]
    public IEnumerable<string> data { get; set; }

    [ReactProp]
    public string id { get; set; }

    [ReactProp]
    [ReactGrabEventArgumentsByUsingFunction(Prefix + nameof(AutoComplete) + "::OnChange")]
    public Action<string> onChange { get; set; }

    [ReactProp]
    public string value { get; set; }

    [ReactProp]
    public string placeholder { get; set; }
}