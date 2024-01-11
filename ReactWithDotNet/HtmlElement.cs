﻿using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace ReactWithDotNet;

abstract partial class HtmlElement : Element
{
    internal Dictionary<string, string> _aria;
    internal Dictionary<string, string> _data;

    internal Style _style;

    internal List<Style> classNameList;

    protected HtmlElement()
    {
    }

    protected HtmlElement(StyleModifier[] styleModifiers)
    {
        this.Apply(styleModifiers);
    }

    protected HtmlElement(params IModifier[] modifiers)
    {
        this.Apply(modifiers);
    }

    protected HtmlElement(string innerText)
    {
        text = innerText;
    }

    protected HtmlElement(Style style)
    {
        this.style.Import(style);
    }

    [JsonPropertyName("$type")]
    public virtual string __type__ => GetType().Name.ToLower();

    [JsonIgnore]
    public Dictionary<string, string> aria
    {
        get
        {
            _aria ??= new();

            return _aria;
        }
    }

    /// <summary>
    ///     The data-* attribute is used to store custom data private to the page or application.
    ///     <br />
    ///     The data-* attribute gives us the ability to embed custom data attributes on all HTML elements.
    ///     <br />
    ///     The stored (custom) data can then be used in the page's JavaScript to create a more engaging user experience
    ///     (without any Ajax calls or server-side database queries).
    ///     <br />
    ///     The data-* attribute consist of two parts:
    ///     <br />
    ///     The attribute name should not contain any uppercase letters, and must be at least one character long after the
    ///     prefix "data-"<br />
    ///     The attribute value can be any string<br />
    ///     Note: Custom attributes prefixed with "data-" will be completely ignored by the user agent.<br />
    /// </summary>
    [JsonIgnore]
    public Dictionary<string, string> data
    {
        get
        {
            _data ??= new();

            return _data;
        }
    }

    [JsonIgnore]
    public string innerHTML
    {
        set => dangerouslySetInnerHTML = value;
    }

    /// <summary>
    ///     'innerText' property of element.
    /// </summary>
    public string innerText { get; set; }

    /// <summary>
    ///     Gets or sets the on click.
    /// </summary>
    [ReactProp]
    [JsonPropertyName("$onClickPreview")]
    public Action onClickPreview { get; set; }

    /// <summary>
    ///     Default value: 400 <br />
    /// </summary>
    public int? onScrollDebounceTimeout { get; set; } = 400;

    /// <summary>
    ///     Gets the style.
    /// </summary>
    [JsonIgnore]
    public Style style
    {
        get
        {
            _style ??= new();

            return _style;
        }
    }

    /// <summary>
    ///     Imports filled values given style
    /// </summary>
    [JsonIgnore]
    public Style Style
    {
        set => style.Import(value);
    }

    /// <summary>
    ///     'innerText' property of element.
    /// </summary>
    public string text
    {
        set => innerText = value;
        get => innerText;
    }

    /// <summary>
    ///     Adds given cssClassName ot class attribute of html element
    /// </summary>
    public void AddClass(string cssClassName)
    {
        if (string.IsNullOrWhiteSpace(className))
        {
            className = cssClassName;
            return;
        }

        className += " " + cssClassName;
    }

    #region Operators

    public static HtmlElement operator +(HtmlElement element, Style style)
    {
        element.style.Import(style);

        return element;
    }

    public static HtmlElement operator +(HtmlElement element, StyleModifier[] styleModifiers)
    {
        element.Apply(styleModifiers);

        return element;
    }

    public static HtmlElement operator +(HtmlElement htmlElement, HtmlElementModifier htmlElementModifier)
    {
        htmlElementModifier?.Process(htmlElement);

        return htmlElement;
    }

    public static HtmlElement operator +(HtmlElement htmlElement, IModifier modifier)
    {
        ModifyHelper.ProcessModifier(htmlElement, modifier);

        return htmlElement;
    }

    public static HtmlElement operator +(HtmlElement htmlElement, StyleModifier styleModifier)
    {
        styleModifier?.ModifyStyle(htmlElement.style);

        return htmlElement;
    }

    public void Add(StyleModifier styleModifier)
    {
        styleModifier?.ModifyStyle(style);
    }

    public void Add(HtmlElementModifier htmlElementModifier)
    {
        htmlElementModifier?.Process(this);
    }

    public void Add(Action<HtmlElement> modifyHtmlElement)
    {
        if (modifyHtmlElement == null)
        {
            return;
        }

        modifyHtmlElement(this);
    }

    [SuppressMessage("ReSharper", "ParameterHidesMember")]
    public void Add(Style style)
    {
        this.style.Import(style);
    }

    #endregion

    #region ValueManagement

    internal sealed class PropertyValueDefinition
    {
        public string name;
    }

    internal sealed class PropertyValueNode
    {
        public PropertyValueNode next, prev;
        public PropertyValueDefinition propertyDefinition;

        public string valueAsString;
    }

    internal void SetValue(ref PropertyValueNode valueNode, PropertyValueDefinition propertyDefinition, string value)
    {
        var shouldRemove = value is null;

        if (valueNode == null)
        {
            if (shouldRemove)
            {
                return;
            }

            valueNode = new()
            {
                propertyDefinition = propertyDefinition,
                valueAsString      = value
            };

            if (_head is null)
            {
                _head = _tail = valueNode;
                return;
            }

            // push end
            _tail.next = valueNode;

            valueNode.prev = _tail;

            _tail = valueNode;

            return;
        }

        if (shouldRemove)
        {
            // R E M O V E

            // head
            if (ReferenceEquals(_head, valueNode))
            {
                // has only one node
                if (ReferenceEquals(_tail, valueNode))
                {
                    _head = _tail = valueNode = null;
                    return;
                }

                // remove head
                _head = _head.next;

                _head.prev = null;

                valueNode = null;

                return;
            }

            // tail
            if (ReferenceEquals(_tail, valueNode))
            {
                _tail = _tail.prev;

                _tail.next = null;

                valueNode = null;

                return;
            }

            // between
            valueNode.prev.next = valueNode.next;
            valueNode.next.prev = valueNode.prev;

            valueNode = null;

            return;
        }

        valueNode.valueAsString = value;
    }

    internal PropertyValueNode _head, _tail;

    #endregion
}

[Serializable]
public sealed class dangerouslySetInnerHTML
{
    public dangerouslySetInnerHTML(string html)
    {
        __html = html;
    }

    public dangerouslySetInnerHTML()
    {
    }

    public string __html { get; set; }

    public static implicit operator dangerouslySetInnerHTML(string html)
    {
        return new() { __html = html };
    }
}

partial class Mixin
{
    public static HtmlElementModifier Aria(string ariaName, string ariaValue)
    {
        return CreateHtmlElementModifier<HtmlElement>(el => el.aria.Add(ariaName, ariaValue));
    }

    public static HtmlElementModifier Data(string dataName, string dataValue)
    {
        return CreateHtmlElementModifier<HtmlElement>(el => el.data.Add(dataName, dataValue));
    }

    public static HtmlElementModifier Data(string dataName, int dataValue)
    {
        return CreateHtmlElementModifier<HtmlElement>(el => el.data.Add(dataName, dataValue.ToString()));
    }

    public static HtmlElementModifier Data(string dataName, long dataValue)
    {
        return CreateHtmlElementModifier<HtmlElement>(el => el.data.Add(dataName, dataValue.ToString()));
    }

    /// <summary>
    ///     Automatically generates a css class then adds class name to element.
    ///     <br />
    ///     You can use transition css
    ///     <br />
    ///     Generated css class will be automatically remove when component destroyed.
    ///     <br />
    ///     Example:
    ///     <code>
    ///     arrowDown.WithStyle(new Style
    ///     {
    ///        Transform("rotate(-180deg)")
    ///     })
    ///     </code>
    /// </summary>
    public static TElement WithStyle<TElement>(this TElement element, Style cssBody) where TElement : HtmlElement
    {
        (element.classNameList ??= []).Add(cssBody);

        return element;
    }

    /// <summary>
    ///     Automatically generates a css class then adds class name to element.
    ///     <br />
    ///     You can use transition css
    ///     <br />
    ///     Generated css class will be automatically remove when component destroyed.
    ///     <br />
    ///     Example:
    ///     <code>
    ///     arrowDown.WithStyle(new []
    ///     {
    ///        Transform("rotate(-180deg)")
    ///     })
    ///     </code>
    /// </summary>
    public static TElement WithStyle<TElement>(this TElement element, IEnumerable<StyleModifier> styleModifiers) where TElement : HtmlElement
    {
        return element.WithStyle(new(styleModifiers));
    }
}