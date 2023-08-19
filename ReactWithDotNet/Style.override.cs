﻿using System.Collections;
using System.Text.Json.Serialization;

namespace ReactWithDotNet;

partial class Style : IEnumerable<StyleModifier>, IModifier
{
    protected static StyleModifier Modify(Action<Style> modifyAction) => CreateStyleModifier(modifyAction);

    public Style()
    {
    }

    public Style(params StyleModifier[] styleModifiers)
    {
        if (styleModifiers is not null)
        {
            foreach (var styleModifier in styleModifiers)
            {
                styleModifier?.ModifyStyle(this);
            }
        }
    }
    
    public Style(IEnumerable<StyleModifier> styleModifiers)
    {
        if (styleModifiers is not null)
        {
            foreach (var styleModifier in styleModifiers)
            {
                styleModifier?.ModifyStyle(this);
            }
        }
    }

    [JsonIgnore]
    public string leftRight
    {
        set
        {
            left  = value;
            right = value;
        }
    }

    [JsonIgnore]
    public string leftRightBottom
    {
        set
        {
            left   = value;
            right  = value;
            bottom = value;
        }
    }

    [JsonIgnore]
    public string topBottom
    {
        set
        {
            top    = value;
            bottom = value;
        }
    }

    [JsonIgnore]
    public string width_height
    {
        set
        {
            width  = value;
            height = value;
        }
    }

    /// <summary>
    ///     Add given <paramref name="styleModifier" /> to <paramref name="style" />
    ///     <br />
    ///     if <paramref name="style" /> is null then returns null.
    /// </summary>
    public static Style operator +(Style style, StyleModifier styleModifier)
    {
        if (style == null || styleModifier == null)
        {
            return null;
        }

        styleModifier.ModifyStyle(style);

        return style;
    }

    #region IEnumerable<Modifier>
    public IEnumerator<StyleModifier> GetEnumerator()
    {
        yield break;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Add(StyleModifier modifier)
    {
        modifier?.ModifyStyle(this);
    }

    public void Add(Style styleForImport)
    {
        if (styleForImport is null)
        {
            return;
        }
        
        Import(styleForImport);
    }
    
    #endregion

    #region margin
    [JsonIgnore]
    public string marginLeftRight
    {
        set
        {
            marginLeft  = value;
            marginRight = value;
        }
    }

    [JsonIgnore]
    public string marginLeftTop
    {
        set
        {
            marginLeft = value;
            marginTop  = value;
        }
    }

    [JsonIgnore]
    public string marginLeftBottom
    {
        set
        {
            marginLeft   = value;
            marginBottom = value;
        }
    }

    [JsonIgnore]
    public string marginTopBottom
    {
        set
        {
            marginTop    = value;
            marginBottom = value;
        }
    }

    [JsonIgnore]
    public string marginTopRight
    {
        set
        {
            marginTop   = value;
            marginRight = value;
        }
    }
    #endregion

    #region Padding
    [JsonIgnore]
    public string paddingLeftRight
    {
        set
        {
            paddingLeft  = value;
            paddingRight = value;
        }
    }

    [JsonIgnore]
    public string paddingLeftTop
    {
        set
        {
            paddingLeft = value;
            paddingTop  = value;
        }
    }

    [JsonIgnore]
    public string paddingLeftBottom
    {
        set
        {
            paddingLeft   = value;
            paddingBottom = value;
        }
    }

    [JsonIgnore]
    public string paddingTopBottom
    {
        set
        {
            paddingTop    = value;
            paddingBottom = value;
        }
    }

    [JsonIgnore]
    public string paddingTopRight
    {
        set
        {
            paddingTop   = value;
            paddingRight = value;
        }
    }

    public string borderInlineStyle { get; set; }
    #endregion

    public Style Clone()
    {
        var clone = new Style();
        
        clone.Import(this);

        return clone;
    }
}