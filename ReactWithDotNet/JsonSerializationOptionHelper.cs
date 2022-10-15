using System.Globalization;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using ReactWithDotNet.PrimeReact;

namespace ReactWithDotNet;

static class JsonSerializationOptionHelper
{
    #region Public Methods
    public static JsonSerializerOptions Modify(JsonSerializerOptions options)
    {
        options.WriteIndented    = true;
        options.IgnoreNullValues = true;

        options.PropertyNamingPolicy = null;

        options.Converters.Add(new JsonConverterForEnum());

        options.Converters.Add(new PrimeReactTreeNodeConverter());

        options.Converters.Add(new StyleConverter());
        options.Converters.Add(new JsMapConverter());
        

        return options;
    }
    #endregion

    public class JsonConverterForEnum : JsonConverterFactory
    {
        #region Public Methods
        public override bool CanConvert(Type typeToConvert)
        {
            if (typeToConvert.Assembly == typeof(JsonConverterForEnum).Assembly)
            {
                return typeToConvert.IsSubclassOf(typeof(Enum));
            }

            return false;
        }

        public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
        {
            var converter = (JsonConverter)Activator.CreateInstance(typeof(EnumToStringConverter<>)
                                                                       .MakeGenericType(typeToConvert),
                                                                    BindingFlags.Instance | BindingFlags.Public,
                                                                    binder: null,
                                                                    args: null,
                                                                    culture: null)!;

            return converter;
        }
        #endregion
    }

    public class PrimeReactTreeNodeConverter : JsonConverterFactory
    {
        public override bool CanConvert(Type typeToConvert)
        {
            return typeToConvert.IsAssignableFrom(typeof(TreeNode));
        }

        public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
        {
            return (JsonConverter)Activator.CreateInstance(typeof(PolymorphicJsonConverter<>).MakeGenericType(typeToConvert));
        }
    }

    class EnumToStringConverter<T> : JsonConverter<T>
    {
        #region Public Methods
        public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }

        public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString()?.ToLower());
        }
        #endregion
    }

    class PolymorphicJsonConverter<T> : JsonConverter<T>
    {
        public override bool CanConvert(Type typeToConvert)
        {
            return typeof(T).IsAssignableFrom(typeToConvert);
        }

        public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }

        public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
        {
            if (value is null)
            {
                writer.WriteNullValue();
                return;
            }

            writer.WriteStartObject();
            foreach (var property in value.GetType().GetProperties())
            {
                if (!property.CanRead)
                    continue;
                var propertyValue = property.GetValue(value);
                writer.WritePropertyName(property.Name);
                JsonSerializer.Serialize(writer, propertyValue, options);
            }

            writer.WriteEndObject();
        }
    }

    class StyleConverter : JsonConverter<Style>
    {
        public override Style Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }

        public override void Write(Utf8JsonWriter writer, Style value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();
            
            value.VisitNotNullValues(add);

            writer.WriteEndObject();

            void add(string propertyName, string propertyValue)
            {
                writer.WritePropertyName(propertyName);

                writer.WriteStringValue(propertyValue);
            }
        }
    }

    class JsMapConverter : JsonConverter<JsMap>
    {
        public override JsMap Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }

        public override void Write(Utf8JsonWriter writer, JsMap jsMap, JsonSerializerOptions options)
        {
            writer.WriteStartObject();

            jsMap.Foreach(add);

            writer.WriteEndObject();

            void add(string key, object value)
            {
                writer.WritePropertyName(key);

                JsonSerializer.Serialize(writer, value);
            }
        }
    }
}

[Serializable]
sealed class RemoteMethodInfo
{
    #region Public Properties
    [JsonPropertyName("$isRemoteMethod")]
    public bool IsRemoteMethod { get; set; }

    public string remoteMethodName { get; set; }

    public int? HandlerComponentUniqueIdentifier { get; set; }
    
    public string FunctionNameOfGrabEventArguments { get; set; }

    public bool? StopPropagation { get; set; }
    #endregion
}

[Serializable]
public sealed class BindInfo
{
    public string defaultValue { get; set; }
    public string eventName { get; set; }

    [JsonPropertyName("$isBinding")]
    public bool IsBinding { get; set; }

    public string[] jsValueAccess { get; set; }

    public string[] sourcePath { get; set; }

    public string targetProp { get; set; }
}

// todo: check usage
public class JsonWriterContext
{
}

public class InnerElementInfo
{
    public object Element { get; set; }

    [JsonPropertyName("$isElement")]
    public bool IsElement { get; set; }
}