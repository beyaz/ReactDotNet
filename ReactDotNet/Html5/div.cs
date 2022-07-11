﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ReactDotNet.Html5;

public class div : HtmlElement
{

    [JsonPropertyName("$type")]
    public override string Type => nameof(div);

    public div()
    {
    }

    public div(string innerText)
    {
        this.innerText = innerText;
    }

    public div(IEnumerable<Element> children)
    {
        this.children.AddRange(children);
    }

    public div(params ElementModifier[] modifiers) : base(modifiers)
    {
    }

    public override string ToString() => this.ToHTML();
}