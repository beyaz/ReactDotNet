﻿namespace ReactWithDotNet;

public sealed class svg : HtmlElement
{
    
    [ReactProp]
    public string focusable { get; set; }
    public svg()
    {
    }

    public svg(params IModifier[] modifiers) : base(modifiers)
    {
    }
    [ReactProp]
    public string version { get; set; }
    [ReactProp]
    public string fill { get; set; }

    [ReactProp]
    public string height { get; set; }

    [ReactProp]
    public string preserveAspectRatio { get; set; }

    [ReactProp]
    public string viewBox { get; set; }

    [ReactProp]
    public string width { get; set; }

    [ReactProp]
    public string xmlns { get; set; } = "http://www.w3.org/2000/svg";
    
    [ReactProp]
    public string xlinkHref { get; set; }
    
    [ReactProp]
    public string xmlnsXlink { get; set; }

    /// <summary>
    ///     svg.width = <paramref name="width" />
    /// </summary>
    public static HtmlElementModifier Width(string width) => Modify<svg>(el => el.width = width);

    /// <summary>
    ///     svg.width = <paramref name="width" /> + 'px'
    /// </summary>
    public static HtmlElementModifier Width(double width) => Width(width.AsPixel());

    /// <summary>
    ///     svg.width = <paramref name="widthAndHeight" />
    /// <br/>
    ///     svg.height = <paramref name="widthAndHeight" />
    /// </summary>
    public static HtmlElementModifier WidthHeight(string widthAndHeight) => Modify<svg>(el =>
    {
        el.width  = widthAndHeight;
        el.height = widthAndHeight;
    });

    /// <summary>
    ///     svg.width = <paramref name="widthAndHeight" /> + 'px'
    /// <br/>
    ///     svg.height = <paramref name="widthAndHeight" /> + 'px'
    /// </summary>
    public static HtmlElementModifier WidthHeight(double widthAndHeight) => WidthHeight(widthAndHeight.AsPixel());

    /// <summary>
    ///     svg.height = <paramref name="height" />
    /// </summary>
    public static HtmlElementModifier Height(string height) => Modify<svg>(el => el.height = height);

    /// <summary>
    ///     svg.height = <paramref name="height" /> + 'px'
    /// </summary>
    public static HtmlElementModifier Height(double height) => Height(height.AsPixel());

    /// <summary>
    ///     svg.fill = <paramref name="color" />
    /// </summary>
    public static HtmlElementModifier Fill(string color) => Modify<svg>(el => el.fill = color);

    /// <summary>
    ///     svg.viewBox = <paramref name="viewBox" />
    /// </summary>
    public static HtmlElementModifier ViewBox(string viewBox) => Modify<svg>(el => el.viewBox = viewBox);

    /// <summary>
    ///     svg.viewBox = '<paramref name="minX" /> <paramref name="minY" /> <paramref name="width" /> <paramref name="height" />'
    /// </summary>
    public static HtmlElementModifier ViewBox(double  minX, double minY, double width, double height) => ViewBox($"{minX} {minY} {width} {height}");

    public static HtmlElementModifier Focusable(string value) => Modify<svg>(el => el.focusable = value);
}

partial class Mixin
{
    
    
    /// <summary>
    ///     svg.viewBox = <paramref name="viewBox" />
    /// </summary>
    public static HtmlElementModifier ViewBox(string viewBox) 
        => svg.ViewBox(viewBox);
    
    /// <summary>
    ///     svg.viewBox = '<paramref name="minX" /> <paramref name="minY" /> <paramref name="width" /> <paramref name="height" />'
    /// </summary>
    public static HtmlElementModifier ViewBox(double  minX, double minY, double width, double height) 
        => svg.ViewBox(  minX,  minY,  width,  height);


}


public sealed class path : HtmlElement
{
    public path()
    {
    }

    public path(params IModifier[] modifiers) : base(modifiers)
    {
    }
    
    [ReactProp]
    public string d { get; set; }

    [ReactProp]
    public string fill { get; set; }
    
    [ReactProp]
    public string fillRule { get; set; }
    
    [ReactProp]
    public string clipRule { get; set; }

    [ReactProp]
    public string stroke { get; set; }
    
    [ReactProp]
    public string strokeLinecap { get; set; }
    
    [ReactProp]
    public string strokeLinejoin { get; set; }
}

public sealed class g : HtmlElement
{
    public g()
    {
    }

    public g(params IModifier[] modifiers) : base(modifiers)
    {
    }
    
    [ReactProp]
    public string opacity { get; set; }
    
    [ReactProp]
    public string clipPath { get; set; }

    [ReactProp]
    public string transform { get; set; }
    
    
    /// <summary>
    ///     g.clipPath = <paramref name="value" />
    /// </summary>
    public static HtmlElementModifier ClipPath(string value) => Modify<g>(el => el.clipPath = value);
}

public sealed class defs : HtmlElement;

public sealed class clipPath : HtmlElement
{
    public clipPath()
    {
        
    }
    public clipPath(params IModifier[] modifiers) : base(modifiers)
    {
    }
}
public sealed class linearGradient : HtmlElement;
public sealed class stop : HtmlElement
{
    [ReactProp]
    public string offset { get; set; }


    [ReactProp]
    public string stopColor { get; set; }


    [ReactProp]
    public string stopOpacity { get; set; }
    
}



