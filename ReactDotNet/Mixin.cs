﻿using System;
using System.Linq;
using System.Reflection;
using System.Text.Json;

namespace ReactDotNet
{
    public static class Mixin
    {
        // public static readonly JsonNamingPolicy JsonNamingPolicy =  JsonNamingPolicy.CamelCase;

        public static  JsonNamingPolicy JsonNamingPolicy;

        public static string ToJson(object value)
        {
            return JsonSerializer.Serialize(value, new JsonSerializerOptions().ModifyForReactDotNet());
        }

        public static void Import(this Style style, Style newStyle)
        {
            foreach (var propertyInfo in typeof(Style).GetProperties())
            {
                var value    = propertyInfo.GetValue(style);
                var newValue = propertyInfo.GetValue(newStyle);

                if (value == null)
                {
                    if (newValue != null)
                    {
                        propertyInfo.SetValue(style, newValue);
                    }

                    continue;
                }

                if (!value.Equals(newValue))
                {
                    propertyInfo.SetValue(style, newValue);
                }

            }
        }
        public static JsonSerializerOptions ModifyForReactDotNet(this JsonSerializerOptions options)
        {
            return JsonSerializationOptionHelper.Modify(options);
        }


        public static T Gravity<T>(this T element, int gravity) where T: Element
        {
            element.gravity = gravity;

            return element;
        }

        public static T IsVisible<T>(this T element, bool isVisible) where T : Element
        {
            element.style.visibility = isVisible ? Visibility.visible : Visibility.collapse;

            return element;
        }

        public static T MakeCenter<T>(this T element) where T : Element
        {
            element.style.display = Display.flex;
            element.style.justifyContent = JustifyContent.center;
            element.style.alignItems = AlignItems.center;

            return element;
        }

        public static T HasBorder<T>(this T element) where T : Element
        {
            element.style.border = "1px solid #ced4da";
            element.style.borderRadius = "3px";            

            return element;
        }

        public static T Padding<T>(this T element, int padding) where T : Element
        {
            element.style.padding = padding + "px";

            return element;
        }

        public static T Style<T>(this T element, Action<Style> modifyStyle) where T : Element
        {
            modifyStyle(element.style);

            return element;
        }

        public static TParent appendChild<TParent,TChild>(this TParent element, TChild child) where TParent : Element where TChild : Element
        {
            element.children.Add(child);

            return element;
        }
        

        public static string px(int value)
        {
            return value + "px";
        }

        public static string px(double value)
        {
            return value + "px";
        }

        public static string AsPercent(this double value)
        {
            return value.ToString().Replace(",",".") + "%";
        }
    }
}