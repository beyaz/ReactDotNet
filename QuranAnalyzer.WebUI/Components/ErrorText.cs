﻿namespace QuranAnalyzer.WebUI.Components;

class ErrorText : ReactComponent
{
    public string Text { get; set; }

    protected override Element render()
    {
        var element = new small
        {
            text = Text,
            style =
            {
                color     = "#e24c4c",
                marginTop = "5px"
            }
        };

        if (Text.HasNoValue())
        {
            element.style.display = "none";
        }

        return element;
    }
}