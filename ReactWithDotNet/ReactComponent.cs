﻿
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Text.Json.Serialization;

namespace ReactWithDotNet;

public abstract class ReactPureComponent
{
    List<StyleModifier> styleModifiers;

    protected abstract Element render();

    internal Element InvokeRender()
    {
        var root = render();

        if (styleModifiers is not null)
        {
            foreach (var styleModifier in styleModifiers)
            {
                ModifyHelper.ProcessModifier(root, styleModifier);
            }
        }

        return root;
    }

    public static ReactPureComponent operator +(ReactPureComponent reactPureComponent, StyleModifier styleModifier)
    {
        (reactPureComponent.styleModifiers ??= new List<StyleModifier>()).Add(styleModifier);

        return reactPureComponent;
    }

    public void Add(ReactPureComponentModifier modifier)
    {
        modifier?.Modify(this);
    }
}

public abstract class ReactPureComponentModifier
{
    internal abstract void Modify(ReactPureComponent pureComponent);
}

public sealed class ReactPureComponentModifier<TPureComponent> where  TPureComponent : ReactPureComponent
{
    internal readonly Action<TPureComponent> modify;

    public ReactPureComponentModifier(Action<TPureComponent> modifyPureComponent)
    {
        modify = modifyPureComponent ?? throw new ArgumentNullException(nameof(modifyPureComponent));
    }

    internal void Modify(ReactPureComponent pureComponent)
    {
        if (pureComponent == null)
        {
            return;
        }
        
        modify((TPureComponent)pureComponent);
    }
}

public abstract class ReactStatefulComponent : Element
{
    internal Style _styleForRootElement;

    internal List<IModifier> modifiers;

    [JsonIgnore]
    [Newtonsoft.Json.JsonIgnore]
    protected internal Client Client { get; internal set; } = new();

    [JsonIgnore]
    [Newtonsoft.Json.JsonIgnore]
    public Style style
    {
        get
        {
            _styleForRootElement ??= new Style();

            return _styleForRootElement;
        }
    }

    [JsonIgnore]
    [Newtonsoft.Json.JsonIgnore]
    protected internal int? ComponentUniqueIdentifier { get; set; }

    [JsonIgnore]
    [Newtonsoft.Json.JsonIgnore]
    protected internal ReactContext Context { get; set; }

    public static ReactStatefulComponent operator +(ReactStatefulComponent component, Style style)
    {
        component.style.Import(style);

        return component;
    }

    [SuppressMessage("ReSharper", "ParameterHidesMember")]
    public void Add(Style style)
    {
        this.style.Import(style);
    }

    internal object Clone()
    {
        return MemberwiseClone();
    }

    internal void InvokeConstructor() => constructor();

    internal Element InvokeRender() => render();

    protected virtual  Task componentDidMount()
    {
        return Task.CompletedTask;
    }

    protected abstract void constructor();

    /// <summary>
    ///     Sample event decleration <br />
    ///     [ReactCustomEvent] public Action OnUserChanged { get; set; }
    ///     <br />
    ///     <br />
    ///     Sample event dispatching <br />
    ///     DispatchEvent(()=> OnUserChanged);
    /// </summary>
    protected void DispatchEvent(Expression<Func<Action>> expressionForAccessingCustomReactEventProperty)
    {
        Client.DispatchDotNetCustomEvent(GetEventSenderInfo(this, GetPropertyNameOfCustomReactEvent((MemberExpression)expressionForAccessingCustomReactEventProperty.Body)));
    }

    /// <summary>
    ///     Sample event decleration <br />
    ///     [ReactCustomEvent] public Action&lt;UserInfo&gt; OnUserChanged { get; set; }
    ///     <br />
    ///     <br />
    ///     Sample event dispatching <br />
    ///     DispatchEvent(()=> OnUserChanged, state.SelectedUserInfo);
    /// </summary>
    protected void DispatchEvent<A>(Expression<Func<Action<A>>> expressionForAccessingCustomReactEventProperty, A a)
    {
        Client.DispatchDotNetCustomEvent(GetEventSenderInfo(this, GetPropertyNameOfCustomReactEvent((MemberExpression)expressionForAccessingCustomReactEventProperty.Body)), a);
    }

    /// <summary>
    ///     Sample event decleration <br />
    ///     [ReactCustomEvent] public Action&lt;UserInfo,OrderInfo&gt; OnUserChanged { get; set; }
    ///     <br />
    ///     <br />
    ///     Sample event dispatching <br />
    ///     DispatchEvent(()=> OnUserChanged, state.SelectedUserInfo, state.SelectedOrderInfo);
    /// </summary>
    protected void DispatchEvent<A, B>(Expression<Func<Action<A, B>>> expressionForAccessingCustomReactEventProperty, A a, B b)
    {
        Client.DispatchDotNetCustomEvent(GetEventSenderInfo(this, GetPropertyNameOfCustomReactEvent((MemberExpression)expressionForAccessingCustomReactEventProperty.Body)), a, b);
    }

    /// <summary>
    ///     Sample event decleration <br />
    ///     [ReactCustomEvent] public Action&lt;UserInfo,OrderInfo,CommissionInfo&gt; OnUserChanged { get; set; }
    ///     <br />
    ///     <br />
    ///     Sample event dispatching <br />
    ///     DispatchEvent(()=> OnUserChanged, state.SelectedUserInfo, state.SelectedOrderInfo, state.SelectedCommissionInfo);
    /// </summary>
    protected void DispatchEvent<A, B, C>(Expression<Func<Action<A, B>>> expressionForAccessingCustomReactEventProperty, A a, B b, C c)
    {
        Client.DispatchDotNetCustomEvent(GetEventSenderInfo(this, GetPropertyNameOfCustomReactEvent((MemberExpression)expressionForAccessingCustomReactEventProperty.Body)), a, b, c);
    }

    protected abstract Element render();

    string GetPropertyNameOfCustomReactEvent(MemberExpression expression)
    {
        var propertyNameOfCustomReactEvent = expression.Member.Name;

        if (GetType().GetProperty(propertyNameOfCustomReactEvent)?.GetCustomAttribute<ReactCustomEventAttribute>() is null)
        {
            throw DeveloperException($"{GetType().FullName}::{propertyNameOfCustomReactEvent} should contains 'ReactCustomEvent' attribute.");
        }

        return propertyNameOfCustomReactEvent;
    }
    
    internal abstract bool IsStateNull { get; }
}

public abstract class ReactComponent<TState> : ReactStatefulComponent where TState : new()
{
    [Newtonsoft.Json.JsonProperty]
    public TState state { get; protected internal set; }

    protected override void constructor()
    {
        state = new TState();
    }

    internal override bool IsStateNull => state == null;
}


public abstract class ReactComponent : ReactComponent<EmptyState>
{
}