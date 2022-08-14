﻿using System;
using QuranAnalyzer.WebUI.Pages.MainPage;

namespace QuranAnalyzer.WebUI;

static class Extensions
{
    public static string GetPageLink(string pageId) => $"/?{QueryKey.Page}=" + pageId;
    
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

    public static (string ChapterFilter, string searchLetters) ParseLetterCountingScript(string value)
    {
        var arr = value.Split("|".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

        return (arr.TryGet(0), arr.TryGet(1));
    }

    public static IReadOnlyList<T> ToReadOnlyList<T>(this IEnumerable<T> items)
    {
        return items.ToList().AsReadOnly();
    }

    public static string GetLetterCountingScript(string chapterFilter, params string[] arabicLetters)
    {
        return chapterFilter + "|" + string.Join(string.Empty, arabicLetters);
    }
}