﻿namespace ReactWithDotNet;

public sealed class div : HtmlElement
{
    [React]
    public string role { get; set; }

   
    

    public div()
    {
    }

    

    public div(string innerText)
    {
        this.innerText = innerText;
    }

    public div(params Modifier[] modifiers) : base(modifiers) { }
    public div(Style style) : base(style) { }

   

}