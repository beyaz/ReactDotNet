﻿using System.Reflection;

namespace ReactWithDotNet;

/// <summary>
///     Functional component.
/// </summary>
public delegate Element FC(Scope cmp);

public interface Scope
{
    public Client Client { get; }

    public Func<Task> ComponentDidMount { set; }

    public Func<Task> Constructor { set; }

    public ReactContext Context { get; }
}

sealed class FunctionalComponent : Component<FunctionalComponent.State>, Scope
{
    internal class State
    {
        /// <summary>
        ///     Scope means value of auto generated fields of CompilerGeneratedType instance.
        /// </summary>
        public IReadOnlyDictionary<string, object> Scope { get; set; }
        
        public Type CompilerGeneratedType { get; init; }
        
        public bool IsRenderAsync { get; init; }
        
        public string RenderMethodNameWithToken { get; init; }

        public bool IsConstructorCalled { get; set; }
    }

    protected override Task constructor()
    {
        state = new()
        {
            IsRenderAsync = IsRenderAsync,
            
            CompilerGeneratedType = CompilerGeneratedType,
            
            RenderMethodNameWithToken = RenderMethodNameWithToken
        };

        return Task.CompletedTask;
    }

    internal object _target;

    internal Func<Task<FC>> renderFuncAsyncWithScope;

    internal FC renderFuncWithScope;

    public Type CompilerGeneratedType { get; init; }

    public Func<Task> ComponentDidMount { internal get; set; }

    public Func<Task> Constructor { internal get; set; }

    public bool IsRenderAsync { get; init; }

    public string RenderMethodNameWithToken { get; init; }

    

    public void InitializeTarget()
    {
        _target ??= SerializationHelperForCompilerGeneratedClasss.Deserialize(state.CompilerGeneratedType, state.Scope);
    }

    internal void CalculateScopeFromTarget()
    {
        var target = _target;

        if (target is null && renderFuncWithScope is not null)
        {
            target = renderFuncWithScope.Target;
        }
        else if (target is null && renderFuncAsyncWithScope is not null)
        {
            target = renderFuncAsyncWithScope.Target;
        }

        if (target is null)
        {
            throw DeveloperException("Invalid usage of useState. target not calculated.");
        }

        state.Scope = SerializationHelperForCompilerGeneratedClasss.Serialize(target);
    }

    protected override Element render()
    {
        if (state.IsRenderAsync)
        {
            return NoneOfRender.Value;
        }

        if (renderFuncWithScope is not null && state.IsConstructorCalled  == false)
        {
            return renderFuncWithScope(this);
        }

        if (_target is null &&  state.IsConstructorCalled)
        {
            InitializeTarget();
        }

        MethodInfo methodInfo = null;
        if (TryResolveMethodInfo(state.RenderMethodNameWithToken, ref methodInfo))
        {
            object[] invocationParameters = null;
            if (methodInfo.GetParameters().Length == 1)
            {
                invocationParameters = [this];
            }

            var renderResult = (Element)methodInfo.Invoke(_target, invocationParameters);

            // protect for calling twice
            Constructor = null;

            return renderResult;
        }

        throw DeveloperException("Invalid usage of useState.");
    }

    protected override async Task<Element> renderAsync()
    {
        if (renderFuncAsyncWithScope is not null)
        {
            var fc = await renderFuncAsyncWithScope();

            return fc?.Invoke(this);
        }

        MethodInfo methodInfo = null;
        if (TryResolveMethodInfo(state.RenderMethodNameWithToken, ref methodInfo))
        {
            object[] invocationParameters = null;
            if (methodInfo.GetParameters().Length == 1)
            {
                invocationParameters = [this];
            }

            var renderResult = (Task<Element>)methodInfo.Invoke(_target, invocationParameters);

            // protect for calling twice
            Constructor = null;

            return renderResult;
        }

        throw DeveloperException("Invalid usage of useState.");
    }
}