﻿using System.Reflection;
using System.Reflection.Emit;
using Newtonsoft.Json;

namespace ReactWithDotNet;

static class ReflectionHelper
{
    public static Func<object, object> CreateGetFunction(PropertyInfo propertyInfo)
    {
        var getMethod = propertyInfo.GetGetMethod();
        if (getMethod == null)
        {
            return null;
        }

        var declaringType = propertyInfo.DeclaringType;
        if (declaringType == null)
        {
            return null;
        }

        var propertyName = propertyInfo.DeclaringType?.FullName + "::" + propertyInfo.Name;

        var dmGet = new DynamicMethod("Get_" + propertyName, typeof(object), new[] { typeof(object) });

        var ilGenerator = dmGet.GetILGenerator();

        ilGenerator.Emit(OpCodes.Ldarg_0);
        ilGenerator.Emit(OpCodes.Castclass, declaringType);
        ilGenerator.Emit(OpCodes.Callvirt, getMethod);

        if (propertyInfo.PropertyType.IsValueType)
        {
            ilGenerator.Emit(OpCodes.Box, propertyInfo.PropertyType);
        }

        ilGenerator.Emit(OpCodes.Ret);

        return (Func<object, object>)dmGet.CreateDelegate(typeof(Func<object, object>));
    }

    public static T DeepCopy<T>(T value)
    {
        var json = JsonConvert.SerializeObject(value);

        return (T)JsonConvert.DeserializeObject(json, value.GetType());
    }

    public static MethodInfo FindMethod(this Type type, string methodName, BindingFlags bindingFlags)
    {
        while (type != null)
        {
            var methodInfo = type.GetMethod(methodName, bindingFlags);
            if (methodInfo != null)
            {
                return methodInfo;
            }

            type = type.BaseType;
        }

        return null;
    }

    public static MethodInfo FindMethodOrGetProperty(this Type type, string propertyNameOrMethodName, BindingFlags bindingFlags)
    {
        while (type != null)
        {
            var propertyInfo = type.GetProperty(propertyNameOrMethodName, bindingFlags);
            if (propertyInfo != null)
            {
                return propertyInfo.GetMethod;
            }

            var methodInfo = type.GetMethod(propertyNameOrMethodName, bindingFlags);
            if (methodInfo != null)
            {
                return methodInfo;
            }

            type = type.BaseType;
        }

        return null;
    }

    public static PropertyInfo FindProperty(this Type type, string propertyName, BindingFlags bindingFlags)
    {
        while (type != null)
        {
            var propertyInfo = type.GetProperty(propertyName, bindingFlags);
            if (propertyInfo != null)
            {
                return propertyInfo;
            }

            type = type.BaseType;
        }

        return null;
    }

    public static IEnumerable<PropertyInfo> GetSerializableProperties(this Type type)
    {
        return type.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.SetProperty | BindingFlags.GetProperty);
    }

    public static bool IsGenericAction1Or2Or3(this Type type)
    {
        var typeDefinition = type.GetGenericTypeDefinition();

        return typeDefinition == typeof(Action<>) || typeDefinition == typeof(Action<,>) || typeDefinition == typeof(Action<,,>);
    }
}