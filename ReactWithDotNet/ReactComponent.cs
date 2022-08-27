﻿using System.Collections.Specialized;
using System.Text.Json.Serialization;

namespace ReactWithDotNet;

public enum ReactComponentEvents
{
    componentDidMount
}

public interface IReactStatelessComponent
{
    string key { get; }
    Element render();
}



public abstract class ReactComponent : Element, IReactStatelessComponent
{
    [JsonIgnore]
    [Newtonsoft.Json.JsonIgnore]
    protected internal ReactContext Context { get; set; }
    
    public abstract Element render();
}

public sealed class ReactContext
{
    readonly Dictionary<string, object> map = new();

    public TValue TryGetValue<TValue>(ReactContextKey<TValue> key)
    {
        if (map.TryGetValue(key.Key, out var value))
        {
            return (TValue)value;
        }

        return default;
    }

    public void Insert<TValue>(ReactContextKey<TValue> key, TValue value)
    {
        Insert(key.Key, value);
    }

    public void Insert<TValue>(string key, TValue value)
    {
        if (map.ContainsKey(key))
        {
            map[key] = value;
            return;
        }

        map.Add(key, value);
    }

    public double ClientWidth { get; internal set; }
    public double ClientHeight { get; internal set; }
    public NameValueCollection Query { get; internal set; }

}




// ReSharper disable once UnusedTypeParameter
public sealed class ReactContextKey<TValue>
{
    public readonly string Key;

    public ReactContextKey(string key)
    {
        Key = key;
    }
}

public sealed class ClientTaskCollection
{
    internal readonly List<ClientTask> taskList = new();


    internal ClientTask[] ToArray() => taskList.ToArray();

    public void CallJsFunction(string JsFunctionPath, params object[] JsFunctionArguments)
    {
        taskList.Add(new ClientTask { TaskId = 0, JsFunctionPath = JsFunctionPath, JsFunctionArguments = JsFunctionArguments });
    }
    public void ListenEvent(string eventName, string routeToMethod)
    {
        taskList.Add(new ClientTask { TaskId = 1, EventName = eventName, RouteToMethod = routeToMethod });
    }


    public void DispatchEvent(string eventName, params object[] eventArguments)
    {
        taskList.Add(new ClientTask { TaskId = 2, EventName = eventName, EventArguments = eventArguments });
    }
    
    public void PushHistory(string title, string url)
    {
        taskList.Add(new ClientTask { TaskId = 4, Title = title, Url = url });
    }

    public void GotoMethod(int timeout, string methodName, params object[] methodArguments)
    {
        taskList.Add(new ClientTask { TaskId = 6, MethodName = methodName, MethodArguments = methodArguments, Timeout = timeout });
    }

    public void NavigateToUrl(string url)
    {
        taskList.Add(new ClientTask { TaskId = 7, Url = url });
    }

    
}

public abstract class ReactStatefulComponent : Element
{
    [JsonIgnore]
    [Newtonsoft.Json.JsonIgnore]
    protected internal ReactContext Context { get; set; }

    public readonly  ClientTaskCollection ClientTask  = new();

    public abstract Element render();

    public event Action StateInitialized;

    internal void OnStateInitialized()
    {
        StateInitialized?.Invoke();
    }
}

public abstract class ReactComponent<TState> : ReactStatefulComponent where TState : new()
{
    public  TState state { get; protected set; }
}