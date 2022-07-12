﻿using System;
using System.Collections;

namespace ReactDotNet.PrimeReact;

public class AutoComplete : ElementBase
{
    [React]
    [ReactBind(targetProp = nameof(value), jsValueAccess = "e.target.value", eventName = "onChange")]
    public BindibleProperty<string> value { get; set; }

    /// <summary>
    ///     An array of suggestions to display.
    /// </summary>
    [React]
    public IEnumerable suggestions { get; set; }

    /// <summary>
    ///     Callback to invoke when autocomplete value changes.
    /// </summary>
    [React]
    public Action<AutoCompleteChangeParams> onChange { get; set; }

    /// <summary>
    ///     Callback to invoke to search for suggestions.
    /// </summary>
    [React]
    public Action<AutoCompleteCompleteMethodParams> completeMethod { get; set; }

    /// <summary>
    ///     Field of a suggested object to resolve and display.
    /// </summary>
    [React]
    public string field { get; set; }

    /// <summary>
    ///     When present, autocomplete clears the manual input if it does not match of the suggestions to force only accepting
    ///     values from the suggestions.
    /// </summary>
    [React]
    public bool forceSelection { get; set; }
}

public class AutoCompleteChangeParams
{
    public string value { get; set; }
}

public class AutoCompleteCompleteMethodParams
{
    public string query { get; set; }
}