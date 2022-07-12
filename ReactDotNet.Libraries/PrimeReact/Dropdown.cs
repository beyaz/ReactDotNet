﻿using System;
using System.Collections;
using System.Linq.Expressions;

namespace ReactDotNet.PrimeReact;

public class Dropdown : ElementBase
{
    [React]
    public Action<DropdownChangeParams> onChange { get; set; }

    [React]
    public string optionLabel { get; set; }
    
    [React]
    public string optionValue { get; set; }

    [React]
    public string placeholder { get; set; }

    [React]
    public IEnumerable options { get; set; }

    [React]
    [ReactBind(targetProp = nameof(value), jsValueAccess = "e.target.value", eventName = "onChange")]
    public BindibleProperty<string> value { get; set; }

    [React]
    public bool? autoFocus { get; set; }
}

public class DropdownChangeParams
{
    public string value { get; set; }
}

