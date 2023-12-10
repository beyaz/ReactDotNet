﻿using System.Collections;

namespace ReactWithDotNet;

/// <summary>
///     The element
/// </summary>
public abstract class Element : IEnumerable<Element>, IEnumerable<IModifier>
{
    internal ElementCollection _children;

    /// <summary>
    ///     The children
    /// </summary>
    [System.Text.Json.Serialization.JsonIgnore]
    public ElementCollection children
    {
        get
        {
            _children ??= new ElementCollection();

            return _children;
        }
    }
    
    public bool HasChildren=>_children == null || _children.Count == 0;

    /// <summary>
    ///     Gets or sets the key.
    /// </summary>
    internal string key { get; set; }

    public static Element operator +(Element element, StyleModifier styleModifier)
    {
        ModifyHelper.ProcessModifier(element, styleModifier);

        return element;
    }

    public static Element operator +(Element element, StyleModifier[] styleModifiers)
    {
        element.Apply(styleModifiers);

        return element;
    }

    public static Element operator +(Element element, Style style)
    {
        ModifyHelper.ProcessModifier(element, CreateStyleModifier(s => s?.Import(style)));

        return element;
    }

    public static Element operator +(Element element, IModifier modifier)
    {
        ModifyHelper.ProcessModifier(element, modifier);

        return element;
    }

    public static implicit operator Element(string text)
    {
        return new HtmlTextNode { text = text };
    }
    public static implicit operator Element(int number)
    {
        return new HtmlTextNode { text = number.ToString() };
    }
    public static implicit operator Element(int? number)
    {
        return new HtmlTextNode { text = number?.ToString() };
    }
    public static implicit operator Element(double? number)
    {
        return new HtmlTextNode { text = number?.ToString() };
    }
    
    public static implicit operator Element(Task<Element> task)
    {
        return new ElementAsTask(task);
    }
    
    public static implicit operator Element(Func<Element> fn)
    {
        return fn();
    }
    public static implicit operator Element(Func<Task<Element>> fn)
    {
        return fn();
    }

    /// <summary>
    ///     Adds the specified element.
    /// </summary>
    public void Add(Element element)
    {
        children.Add(element);
    }
    
    public void Add(params IModifier[] modifiers)
    {
        this.Apply(modifiers);
    }
    
    public void Add(StyleModifier[] modifiers)
    {
        this.Apply(modifiers);
    }

    public void Add(IEnumerable<Element> elements)
    {
        if (elements is not null)
        {
            children.AddRange(elements);
        }
    }

    public void Add(IModifier modifier)
    {
        ModifyHelper.ProcessModifier(this, modifier);
    }

    /// <summary>
    ///     Invokes <paramref name="elementCreatorFunc" /> then adds return value to children.
    /// </summary>
    public void Add(Func<Element> elementCreatorFunc)
    {
        if (elementCreatorFunc == null)
        {
            return;
        }
        
        Add(elementCreatorFunc.Invoke());
    }
    
    /// <summary>
    ///     Invokes <paramref name="elementCreatorFunc" /> then adds return value to children.
    /// </summary>
    public void Add(Func<Task<Element>> elementCreatorFunc)
    {
        if (elementCreatorFunc == null)
        {
            return;
        }
        
        Add(elementCreatorFunc.Invoke());
    }
    
    public void Add<TElement>(Action<TElement> action) where TElement : Element
    {
        if (action == null)
        {
            return;
        }
        
        action.Invoke((TElement)this);
    }

    /// <summary>
    ///     Gets the enumerator.
    /// </summary>
    public IEnumerator<Element> GetEnumerator()
    {
        return children.GetEnumerator();
    }

    public string ToHtml()
    {
        return CalculateComponentHtmlText(new CalculateComponentHtmlTextInput
        {
            Component = new ToStringHandlerComponent(this)
        }).GetAwaiter().GetResult().ToString();
    }

    /// <summary>
    ///     Gets the enumerator.
    /// </summary>
    IEnumerator IEnumerable.GetEnumerator()
    {
        return children.GetEnumerator();
    }

    IEnumerator<IModifier> IEnumerable<IModifier>.GetEnumerator()
    {
        return Enumerable.Empty<IModifier>().GetEnumerator();
    }

    class ToStringHandlerComponent : PureComponent
    {
        Element _element;

        public ToStringHandlerComponent(Element element)
        {
            _element = element;
        }

        protected override Element render()
        {
            return _element;
        }
    }
}

sealed class FakeChild : Element
{
    public int Index { get; set; }
}

sealed class ElementAsTask : Element
{
    public readonly Task<Element> Value;

    public ElementAsTask(Task<Element> value)
    {
        Value = value;
    }
    
    internal LinkedList<IModifier> Modifiers;
}