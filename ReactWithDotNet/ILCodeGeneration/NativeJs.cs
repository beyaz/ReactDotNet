﻿using static ReactWithDotNet.NativeJs;

namespace ReactWithDotNet;


sealed class StackFrame
{
    public MethodDefinitionModel Method;
    public Array EvaluationStack;
    public Array LocalVariables;
    public Array MethodArguments;
    public int MethodArgumentsOfset;
    public int Line;
}

sealed class Address
{
    public Array Array;
    public int Index;
}

sealed class ThreadModel
{
    public Array CallStack;
    public int Line;
}

static class NativeJs
{
    public static extern object CreateNewPlainObject();
    public static extern TValue Get<TInstance, TValue>(TInstance instance, string key);
    public static extern void Set<TInstance, TValue>(TInstance instance, string key, TValue value);
}

static class InterpreterBridge
{
    public static void NewObj(ThreadModel threadModel)
    {
        
    }
    
    public static void GoPreviousMethod(ThreadModel threadModel)
    {
        
    }
}

sealed class JsObject
{
    public T GetValue<T>(string key)
    {
        return Get<JsObject, T>(this, key);
    }

    public void SetValue<T>(string key, T value)
    {
        Set(this, key, value);
    }
}