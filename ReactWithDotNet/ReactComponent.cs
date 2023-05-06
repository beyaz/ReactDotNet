﻿using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using Newtonsoft.Json;

namespace ReactWithDotNet;

public abstract class ReactComponentBase : Element
{
    internal Func<Element> _designerCustomizedRender;
    internal Style _styleForRootElement;

    internal List<IModifier> modifiers;

    [System.Text.Json.Serialization.JsonIgnore]
    [JsonIgnore]
    public Style style
    {
        get
        {
            _styleForRootElement ??= new Style();

            return _styleForRootElement;
        }
    }

    internal abstract bool IsStateNull { get; }

    [System.Text.Json.Serialization.JsonIgnore]
    [JsonIgnore]
    protected internal Client Client { get; internal set; } = new();

    [System.Text.Json.Serialization.JsonIgnore]
    [JsonIgnore]
    protected internal int? ComponentUniqueIdentifier { get; set; }

    [System.Text.Json.Serialization.JsonIgnore]
    [JsonIgnore]
    protected internal ReactContext Context { get; internal set; }

    public static ReactComponentBase operator +(ReactComponentBase component, Style style)
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

    internal Element InvokeRender() => _designerCustomizedRender == null ? render() : _designerCustomizedRender();

    protected virtual Task componentDidMount()
    {
        return Task.CompletedTask;
    }

    protected abstract void constructor();

    /// <summary>
    ///     Sample event declaration <br />
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
}

public abstract class ReactComponent<TState> : ReactComponentBase where TState : new()
{
    [JsonProperty]
    public TState state { get; protected internal set; }

    internal override bool IsStateNull => state == null;

    protected override void constructor()
    {
        state = new TState();
    }
}

public abstract class ReactComponent : ReactComponent<EmptyState>
{
    protected static IModifier Modify<TComponent>(Action<TComponent> modifyAction)
        where TComponent : ReactComponent => CreateComponentModifier(modifyAction);
}

[Serializable]
public sealed class EmptyState
{
}