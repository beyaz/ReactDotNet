﻿using ReactWithDotNet;

namespace QuranAnalyzer;

public static class ListExtensions
{
    #region Public Methods
    public static Response<TAccumulate> Aggregate<TSource, TAccumulate>(this IEnumerable<TSource> source, TAccumulate seed, Func<TSource, Response<TAccumulate>> func, Func<TAccumulate, TAccumulate, TAccumulate> acumulate)
    {
        if (source == null)
        {
            throw new ArgumentNullException(nameof(source));
        }

        if (func == null)
        {
            throw new ArgumentNullException(nameof(func));
        }

        var result = seed;
        foreach (var element in source)
        {
            var response = func(element);
            if (response.IsFail)
            {
                return response.Errors.ToArray();
            }

            result = acumulate(result, response.Value);
        }

        return result;
    }

    public static int Contains(this IReadOnlyList<string> source, IReadOnlyList<string> search)
    {
        if (search.Count > source.Count)
        {
            return 0;
        }

        var count = 0;
        for (var i = 0; i < source.Count; i++)
        {
            if (i + search.Count >= source.Count)
            {
                return count;
            }

            var difference = i;

            var isMatch = true;
            for (var j = 0; j < search.Count; j++)
            {
                if (source[difference + j] != search[j])
                {
                    isMatch = false;
                    break;
                }
            }

            if (isMatch)
            {
                count++;
            }
        }

        return count;
    }

    

    public static bool EndsWith(this IReadOnlyList<string> source, IReadOnlyList<string> search)
    {
        if (search.Count > source.Count)
        {
            return false;
        }

        var sourceIndex = source.Count - search.Count;

        for (var i = 0; i < search.Count; i++)
        {
            if (source[sourceIndex + i] != search[i])
            {
                return false;
            }
        }

        return true;
    }

    public static bool HasValueAndSame(this IReadOnlyList<string> a, IReadOnlyList<string> b)
    {
        if (a == null || b == null)
        {
            return false;
        }

        if (a.Count != b.Count)
        {
            return false;
        }

        var length = a.Count;

        for (var i = 0; i < length; i++)
        {
            if (a[i] != b[i])
            {
                return false;
            }
        }

        return true;
    }

    public static bool HasValueAndSame(this IReadOnlyList<LetterMatchInfo> a, IReadOnlyList<LetterMatchInfo> b)
    {
        if (a == null || b == null)
        {
            return false;
        }

        a = a.Where(x => x.ArabicLetterIndex >= 0).ToList();
        b = b.Where(x => x.ArabicLetterIndex >= 0).ToList();

        if (a.Count != b.Count)
        {
            return false;
        }

        var length = a.Count;

        for (var i = 0; i < length; i++)
        {
            if (!a[i].HasValueAndSameAs(b[i]))
            {
                return false;
            }
        }

        return true;
    }

    public static bool EndsWith(this IReadOnlyList<LetterMatchInfo> source, IReadOnlyList<LetterMatchInfo> search)
    {
        if (source is null)
        {
            throw new ArgumentNullException(nameof(source));
        }

        if (search is null)
        {
            throw new ArgumentNullException(nameof(search));
        }

        source = source.Where(x => x.ArabicLetterIndex >= 0).ToList();
        search = search.Where(x => x.ArabicLetterIndex >= 0).ToList();

        if (search.Count > source.Count)
        {
            return false;
        }

        var sourceIndex = source.Count - search.Count;

        for (var i = 0; i < search.Count; i++)
        {
            if (source[sourceIndex + i].ArabicLetterIndex != search[i].ArabicLetterIndex)
            {
                return false;
            }
        }

        return true;
    }

    public static int Contains(this IReadOnlyList<LetterMatchInfo> source, IReadOnlyList<LetterMatchInfo> search)
    {
        if (source is null)
        {
            throw new ArgumentNullException(nameof(source));
        }

        if (search is null)
        {
            throw new ArgumentNullException(nameof(search));
        }

        source = source.Where(x => x.ArabicLetterIndex >= 0).ToList();
        search = search.Where(x => x.ArabicLetterIndex >= 0).ToList();
        
        if (search.Count > source.Count)
        {
            return 0;
        }

        var count = 0;
        for (var i = 0; i < source.Count; i++)
        {
            if (i + search.Count >= source.Count)
            {
                return count;
            }

            var difference = i;

            var isMatch = true;
            for (var j = 0; j < search.Count; j++)
            {
                if (source[difference + j].ArabicLetterIndex != search[j].ArabicLetterIndex)
                {
                    isMatch = false;
                    break;
                }
            }

            if (isMatch)
            {
                count++;
            }
        }

        return count;
    }

    public static Response<int> Sum<TSource>(this IEnumerable<TSource> source, Func<TSource, Response<int>> selector)
    {
        if (source == null)
        {
            throw new ArgumentNullException(nameof(source));
        }

        return source.Aggregate(0, selector, (total, value) => total + value);
    }
    #endregion


    

}