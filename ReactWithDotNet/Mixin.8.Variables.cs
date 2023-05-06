﻿namespace ReactWithDotNet;

partial class Mixin
{


    /// <summary>
    ///     50|percent returns like '50%'
    /// </summary>
    public static readonly CssUnit percent = new("%", "");

    /// <summary>
    ///     2|rem returns like '2rem'
    /// </summary>
    public static readonly CssUnit rem = new("rem", "");

    /// <summary>
    ///     7|vh returns like '7vh'
    /// </summary>
    public static readonly CssUnit vh = new("vh", "");

    /// <summary>
    ///     7|vw returns like '7vw'
    /// </summary>
    public static readonly CssUnit vw = new("vw", "");

    /// <summary>
    ///     'linear-gradient(<paramref name="degree" /><b>+deg</b>, <paramref name="fromColor" />, <paramref name="toColor" />
    ///     )'
    /// </summary>
    public static string linear_gradient(int degree, string fromColor, string toColor)
        => $"linear-gradient({degree}deg, {fromColor}, {toColor})";

    /// <summary>
    ///     'linear-gradient(<b>to </b><paramref name="directionFrom" /> <paramref name="directionTo" />,
    ///     <paramref name="fromColor" />, <paramref name="toColor" />)'
    /// </summary>
    public static string linear_gradientTo(string directionFrom, string directionTo, string fromColor, string toColor)
        => $"linear-gradient(to {directionFrom} {directionTo}, {fromColor}, {toColor})";

    /// <summary>
    ///     'linear-gradient(<b>to </b> <paramref name="targetDirection" />,
    ///     <paramref name="fromColor" />, <paramref name="toColor" />)'
    /// </summary>
    public static string linear_gradientTo(string targetDirection, string fromColor, string toColor)
        => $"linear-gradient(to {targetDirection}, {fromColor}, {toColor})";

    /// <summary>
    ///     Return new string as 'rgb(<paramref name="red" />, <paramref name="green" />, <paramref name="blue" />)'
    /// </summary>
    public static string rgb(int red, int green, int blue)
        => $"rgb({red}, {green}, {blue})";

    /// <summary>
    ///     Return new string as 'rgb(<paramref name="red" />, <paramref name="green" />, <paramref name="blue" />,
    ///     <paramref name="alpha" />)'
    /// </summary>
    public static string rgba(int red, int green, int blue, double alpha)
        => $"rgba({red},{green},{blue},{alpha})";

    public static StyleModifier Width(CssUnit width) => Width(width.ToString());

    public static StyleModifier Width(string width) => new(style => style.width = width);

    public const string inherit = "inherit";
}

public sealed class CssUnit
{
    /// <summary>
    ///     2|em returns like '2em'
    /// </summary>
    public static readonly CssUnit em = new("em", "");
    
    readonly string finalValue;
    readonly string type;

    internal CssUnit(string type, string finalValue)
    {
        this.type       = type;
        this.finalValue = finalValue;
    }

    public static CssUnit operator |(double value, CssUnit cssUnit)
    {
        return new CssUnit(cssUnit.type, value + cssUnit.type);
    }

    public static implicit operator CssUnit(double valueInPx)
    {
        return new CssUnit("px", valueInPx + "px");
    }

    public static implicit operator CssUnit(int valueInPx)
    {
        return new CssUnit("px", valueInPx + "px");
    }

    public override string ToString()
    {
        return finalValue;
    }
}