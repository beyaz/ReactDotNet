﻿namespace QuranAnalyzer.WebUI.Components;

public class Switch : ReactComponent
{
    public bool IsChecked { get; set; }
    
    protected override Element render()
    {
        Style style = new()
        {
            ComponentBorder,
            Background("#ced4da"),
            BorderRadius(30),
            CursorPointer,
            Transition("background-color 0.2s, color 0.2s, border-color 0.2s, box-shadow 0.2s"),

            Focus(Border($"1px solid {BluePrimary}")),

            Width("3rem"),
            Height("1.75rem"),
            PositionRelative

        };

        var before = new Style
        {
            content            = "",
            background         = "white",
            width              = "1.25rem",
            height             = "1.25rem",
            left               = "0.25rem",
            marginTop          = "-0.625rem",
            borderRadius       = "50%",
            transitionDuration = "0.2s",
            position           = "absolute",
            top                = "50%"
        };

        if (IsChecked)
        {
            style.background = "#6366F1";
            before.transform = "translateX(1.25rem)";
        }
        
        style.before.Import(before);

        return new div(style)
        {
            OnClick(_=>IsChecked = !IsChecked)
        };
    }
}