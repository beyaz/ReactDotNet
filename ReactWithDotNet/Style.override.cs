﻿using System.Collections;
using System.Text.Json.Serialization;

namespace ReactWithDotNet;

partial class Style : IEnumerable<Modifier>
{
    #region IEnumerable<Modifier>
    public IEnumerator<Modifier> GetEnumerator()
    {
        throw new InvalidOperationException("Style data should be serialize after .ToDictionary() method called.");
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Add(Modifier modifier)
    {
        modifier?.Apply(this);
    } 
    #endregion

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

    
}