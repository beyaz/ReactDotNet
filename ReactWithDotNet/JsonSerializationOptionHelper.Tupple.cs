using System.Text.Json;
using System.Text.Json.Serialization;

namespace ReactWithDotNet;

partial class JsonSerializationOptionHelper
{
    class ValueTupleConverter<T1> : JsonConverter<ValueTuple<T1>>
    {
        public override ValueTuple<T1> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            ValueTuple<T1> result = default;

            if (!reader.Read())
            {
                throw new JsonException();
            }

            while (reader.TokenType != JsonTokenType.EndObject)
            {
                if (reader.ValueTextEquals("Item1") && reader.Read())
                {
                    result.Item1 = JsonSerializer.Deserialize<T1>(ref reader, options);
                }
                else
                {
                    throw new JsonException();
                }

                reader.Read();
            }

            return result;
        }

        public override void Write(Utf8JsonWriter writer, ValueTuple<T1> value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("Item1");
            JsonSerializer.Serialize(writer, value.Item1, options);
            writer.WriteEndObject();
        }
    }

    class ValueTupleConverter<T1, T2> : JsonConverter<ValueTuple<T1, T2>>
    {
        public override (T1, T2) Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            (T1, T2) result = default;

            if (!reader.Read())
            {
                throw new JsonException();
            }

            while (reader.TokenType != JsonTokenType.EndObject)
            {
                if (reader.ValueTextEquals("Item1") && reader.Read())
                {
                    result.Item1 = JsonSerializer.Deserialize<T1>(ref reader, options);
                }
                else if (reader.ValueTextEquals("Item2") && reader.Read())
                {
                    result.Item2 = JsonSerializer.Deserialize<T2>(ref reader, options);
                }
                else
                {
                    throw new JsonException();
                }

                reader.Read();
            }

            return result;
        }

        public override void Write(Utf8JsonWriter writer, (T1, T2) value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("Item1");
            JsonSerializer.Serialize(writer, value.Item1, options);
            writer.WritePropertyName("Item2");
            JsonSerializer.Serialize(writer, value.Item2, options);
            writer.WriteEndObject();
        }
    }

    class ValueTupleConverter<T1, T2, T3> : JsonConverter<ValueTuple<T1, T2, T3>>
    {
        public override (T1, T2, T3) Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            (T1, T2, T3) result = default;

            if (!reader.Read())
            {
                throw new JsonException();
            }

            while (reader.TokenType != JsonTokenType.EndObject)
            {
                if (reader.ValueTextEquals("Item1") && reader.Read())
                {
                    result.Item1 = JsonSerializer.Deserialize<T1>(ref reader, options);
                }
                else if (reader.ValueTextEquals("Item2") && reader.Read())
                {
                    result.Item2 = JsonSerializer.Deserialize<T2>(ref reader, options);
                }
                else if (reader.ValueTextEquals("Item3") && reader.Read())
                {
                    result.Item3 = JsonSerializer.Deserialize<T3>(ref reader, options);
                }
                else
                {
                    throw new JsonException();
                }

                reader.Read();
            }

            return result;
        }

        public override void Write(Utf8JsonWriter writer, (T1, T2, T3) value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("Item1");
            JsonSerializer.Serialize(writer, value.Item1, options);
            writer.WritePropertyName("Item2");
            JsonSerializer.Serialize(writer, value.Item2, options);
            writer.WritePropertyName("Item3");
            JsonSerializer.Serialize(writer, value.Item3, options);
            writer.WriteEndObject();
        }
    }

    class ValueTupleConverter<T1, T2, T3, T4> : JsonConverter<ValueTuple<T1, T2, T3, T4>>
    {
        public override (T1, T2, T3, T4) Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            (T1, T2, T3, T4) result = default;

            if (!reader.Read())
            {
                throw new JsonException();
            }

            while (reader.TokenType != JsonTokenType.EndObject)
            {
                if (reader.ValueTextEquals("Item1") && reader.Read())
                {
                    result.Item1 = JsonSerializer.Deserialize<T1>(ref reader, options);
                }
                else if (reader.ValueTextEquals("Item2") && reader.Read())
                {
                    result.Item2 = JsonSerializer.Deserialize<T2>(ref reader, options);
                }
                else if (reader.ValueTextEquals("Item3") && reader.Read())
                {
                    result.Item3 = JsonSerializer.Deserialize<T3>(ref reader, options);
                }
                else if (reader.ValueTextEquals("Item4") && reader.Read())
                {
                    result.Item4 = JsonSerializer.Deserialize<T4>(ref reader, options);
                }
                else
                {
                    throw new JsonException();
                }

                reader.Read();
            }

            return result;
        }

        public override void Write(Utf8JsonWriter writer, (T1, T2, T3, T4) value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("Item1");
            JsonSerializer.Serialize(writer, value.Item1, options);
            writer.WritePropertyName("Item2");
            JsonSerializer.Serialize(writer, value.Item2, options);
            writer.WritePropertyName("Item3");
            JsonSerializer.Serialize(writer, value.Item3, options);
            writer.WritePropertyName("Item4");
            JsonSerializer.Serialize(writer, value.Item4, options);
            writer.WriteEndObject();
        }
    }

    class ValueTupleConverter<T1, T2, T3, T4, T5> : JsonConverter<ValueTuple<T1, T2, T3, T4, T5>>
    {
        public override (T1, T2, T3, T4, T5) Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            (T1, T2, T3, T4, T5) result = default;

            if (!reader.Read())
            {
                throw new JsonException();
            }

            while (reader.TokenType != JsonTokenType.EndObject)
            {
                if (reader.ValueTextEquals("Item1") && reader.Read())
                {
                    result.Item1 = JsonSerializer.Deserialize<T1>(ref reader, options);
                }
                else if (reader.ValueTextEquals("Item2") && reader.Read())
                {
                    result.Item2 = JsonSerializer.Deserialize<T2>(ref reader, options);
                }
                else if (reader.ValueTextEquals("Item3") && reader.Read())
                {
                    result.Item3 = JsonSerializer.Deserialize<T3>(ref reader, options);
                }
                else if (reader.ValueTextEquals("Item4") && reader.Read())
                {
                    result.Item4 = JsonSerializer.Deserialize<T4>(ref reader, options);
                }
                else if (reader.ValueTextEquals("Item5") && reader.Read())
                {
                    result.Item5 = JsonSerializer.Deserialize<T5>(ref reader, options);
                }
                else
                {
                    throw new JsonException();
                }

                reader.Read();
            }

            return result;
        }

        public override void Write(Utf8JsonWriter writer, (T1, T2, T3, T4, T5) value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("Item1");
            JsonSerializer.Serialize(writer, value.Item1, options);
            writer.WritePropertyName("Item2");
            JsonSerializer.Serialize(writer, value.Item2, options);
            writer.WritePropertyName("Item3");
            JsonSerializer.Serialize(writer, value.Item3, options);
            writer.WritePropertyName("Item4");
            JsonSerializer.Serialize(writer, value.Item4, options);
            writer.WritePropertyName("Item5");
            JsonSerializer.Serialize(writer, value.Item5, options);
            writer.WriteEndObject();
        }
    }

    class ValueTupleConverter<T1, T2, T3, T4, T5, T6> : JsonConverter<ValueTuple<T1, T2, T3, T4, T5, T6>>
    {
        public override (T1, T2, T3, T4, T5, T6) Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            (T1, T2, T3, T4, T5, T6) result = default;

            if (!reader.Read())
            {
                throw new JsonException();
            }

            while (reader.TokenType != JsonTokenType.EndObject)
            {
                if (reader.ValueTextEquals("Item1") && reader.Read())
                {
                    result.Item1 = JsonSerializer.Deserialize<T1>(ref reader, options);
                }
                else if (reader.ValueTextEquals("Item2") && reader.Read())
                {
                    result.Item2 = JsonSerializer.Deserialize<T2>(ref reader, options);
                }
                else if (reader.ValueTextEquals("Item3") && reader.Read())
                {
                    result.Item3 = JsonSerializer.Deserialize<T3>(ref reader, options);
                }
                else if (reader.ValueTextEquals("Item4") && reader.Read())
                {
                    result.Item4 = JsonSerializer.Deserialize<T4>(ref reader, options);
                }
                else if (reader.ValueTextEquals("Item5") && reader.Read())
                {
                    result.Item5 = JsonSerializer.Deserialize<T5>(ref reader, options);
                }
                else if (reader.ValueTextEquals("Item6") && reader.Read())
                {
                    result.Item6 = JsonSerializer.Deserialize<T6>(ref reader, options);
                }
                else
                {
                    throw new JsonException();
                }

                reader.Read();
            }

            return result;
        }

        public override void Write(Utf8JsonWriter writer, (T1, T2, T3, T4, T5, T6) value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("Item1");
            JsonSerializer.Serialize(writer, value.Item1, options);
            writer.WritePropertyName("Item2");
            JsonSerializer.Serialize(writer, value.Item2, options);
            writer.WritePropertyName("Item3");
            JsonSerializer.Serialize(writer, value.Item3, options);
            writer.WritePropertyName("Item4");
            JsonSerializer.Serialize(writer, value.Item4, options);
            writer.WritePropertyName("Item5");
            JsonSerializer.Serialize(writer, value.Item5, options);
            writer.WritePropertyName("Item6");
            JsonSerializer.Serialize(writer, value.Item6, options);
            writer.WriteEndObject();
        }
    }

    class ValueTupleFactory : JsonConverterFactory
    {
        public override bool CanConvert(Type typeToConvert)
        {
            var iTuple = typeToConvert.GetInterface("System.Runtime.CompilerServices.ITuple");
            return iTuple != null;
        }

        public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
        {
            var genericArguments = typeToConvert.GetGenericArguments();

            var converterType = genericArguments.Length switch
            {
                1 => typeof(ValueTupleConverter<>).MakeGenericType(genericArguments),
                2 => typeof(ValueTupleConverter<,>).MakeGenericType(genericArguments),
                3 => typeof(ValueTupleConverter<,,>).MakeGenericType(genericArguments),
                4 => typeof(ValueTupleConverter<,,,>).MakeGenericType(genericArguments),
                5 => typeof(ValueTupleConverter<,,,,>).MakeGenericType(genericArguments),
                6 => typeof(ValueTupleConverter<,,,,,>).MakeGenericType(genericArguments),
                // And add other cases as needed
                _ => throw new NotSupportedException()
            };
            return (JsonConverter)Activator.CreateInstance(converterType);
        }
    }
}