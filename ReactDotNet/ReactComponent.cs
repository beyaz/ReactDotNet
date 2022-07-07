﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ReactDotNet.Html5
{
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
        public abstract Element render();

        internal ElementModifier modifier;


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
        Element RootElement { get; }

        ReactContext Context { get; set; }

        void constructor();
    }

    public abstract class ReactComponent<TState> : Element, IReactStatefulComponent where TState : new()
    {
        [JsonIgnore]
        public ReactContext Context { get; set; }

        public abstract void constructor();

        public Element RootElement => render();

        public string fullName => GetType().GetFullName();

        public string FullTypeName => GetType().GetFullName();


        public abstract Element render();


        public TState state { get; set; }

        public string FullTypeNameOfState => typeof(TState).GetFullName();

        public int? UniqueIdOfState { get; set; }
    }
}