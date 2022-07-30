﻿using System;

namespace QuranAnalyzer.WebUI;

static class Extensions
{
    public static string GetPageLink(string pageId) => "/wwwroot/index.html?page=" + pageId;
    
    public static bool HasNoValue(this string value) => string.IsNullOrWhiteSpace(value);

    public static bool HasValue(this string value) => !string.IsNullOrWhiteSpace(value);

    public static T TryGet<T>(this T[] array, int index)
    {
        try
        {
            return array[index];
        }
        catch (Exception)
        {
            return default;
        }
    }
}