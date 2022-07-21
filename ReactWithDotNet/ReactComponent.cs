﻿using System;
using System.Collections.Generic;
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
    
    public IReadOnlyList<object> ClientTasks { get; set; }

    #region Add to Client task

    internal readonly  List<ClientTask> ClientTasks_ = new();

    public void AddClientTaskCallJsFunction(string JsFunctionPath, object[] JsFunctionArguments)
    {
        ClientTasks_.Add(new ClientTask{ TaskId = 0, JsFunctionPath = JsFunctionPath, JsFunctionArguments = JsFunctionArguments});
    }
    public void AddClientTaskListenEvent(string eventName, string routeToMethod)
    {
        ClientTasks_.Add(new ClientTask { TaskId = 1, EventName = eventName, RouteToMethod = routeToMethod });
    }


    public void AddClientTaskDispatchEvent(string eventName, object[] eventArguments)
    {
        ClientTasks_.Add(new ClientTask { TaskId = 2, EventName = eventName, EventArguments = eventArguments });
    }

    public void AddClientTaskListenComponentEvent(string eventName, string routeToMethod)
    {
        ClientTasks_.Add(new ClientTask { TaskId = 3, EventName = eventName, RouteToMethod = routeToMethod });
    }

    public void AddClientTaskPushHistory(string title, string url)
    {
        ClientTasks_.Add(new ClientTask { TaskId = 4, Title = title, Url = url });
    }

    public void AddClientTaskComebackWithLastAction(int timeout)
    {
        ClientTasks_.Add(new ClientTask { TaskId = 5, Timeout = timeout });
    }

    public void AddClientTaskGotoMethod(string methodName, object[] methodArguments, int timeout)
    {
        ClientTasks_.Add(new ClientTask { TaskId = 6, MethodName = methodName, MethodArguments = methodArguments, Timeout = timeout });
    }

    public void AddClientTaskNavigateToUrl(string url)
    {
        ClientTasks_.Add(new ClientTask { TaskId = 7, Url = url });
    }

    #endregion
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



public static class BrowserInformation
{
    public static ReactContextKey<double> AvailableWidth = new(nameof(AvailableWidth));
    public static ReactContextKey<double> AvailableHeight = new(nameof(AvailableHeight));
    public static ReactContextKey<IReadOnlyDictionary<string, string>> UrlParameters = new(nameof(UrlParameters));

}






public interface IReactStatefulComponent
{
    Element ___RootNode___ { get; }

    ReactContext Context { get; set; }
        
    string ___Type___ { get; }

    string ___TypeOfState___ { get; }

    bool ___HasComponentDidMountMethod___ { get; }
        
    Element render();

    event Action StateInitialized;
}

public abstract class ReactStatefulComponent : Element
{
    [JsonIgnore]
    [Newtonsoft.Json.JsonIgnore]
    public ReactContext Context { get; set; }

    public Element ___RootNode___ => render();

    public string ___Type___ => GetType().GetFullName();


    public bool ___HasComponentDidMountMethod___ => GetType().GetMethod("ComponentDidMount") != null;


    public abstract Element render();

    public event Action StateInitialized;

    internal void OnStateInitialized()
    {
        StateInitialized?.Invoke();
    }
}

public abstract class ReactComponent<TState> : ReactStatefulComponent, IReactStatefulComponent where TState : new()
{
    public string ___TypeOfState___ => typeof(TState).GetFullName();

    public  TState state { get; protected set; }
}