namespace ReactWithDotNet;

class DynamicStyleContentForEmbeddInClient
{
    internal readonly List<CssClassInfo> listOfClasses = new();

    public JsonMap CalculateCssClassList()
    {
        if (!listOfClasses.Any())
        {
            return null;
        }

        var jsonMap = new JsonMap();

        foreach (var cssClassInfo in listOfClasses)
        {
            cssClassInfo.WriteTo(jsonMap);
        }

        return jsonMap;
    }

    public string GetClassName(CssClassInfo cssClassInfo)
    {
        // change name until is unique
        {
            var suffix = 0;
            while (true)
            {
                var newName = cssClassInfo.Name + suffix++;

                if (listOfClasses.Any(x => x.Name == newName))
                {
                    continue;
                }

                cssClassInfo = new CssClassInfo
                {
                    Name         = newName,
                    Pseudos      = cssClassInfo.Pseudos,
                    MediaQueries = cssClassInfo.MediaQueries
                };

                break;
            }
        }

        listOfClasses.Add(cssClassInfo);

        return cssClassInfo.Name;
    }
}

class CssPseudoCodeInfo
{
    public string BodyOfCss { get; init; }
    public string Name { get; init; }
}

class CssClassInfo
{
    public int? ComponentUniqueIdentifier { get; init; }
    public IReadOnlyList<(string mediaRule, string cssBody)> MediaQueries { get; set; }
    public string Name { get; init; }
    public IReadOnlyList<CssPseudoCodeInfo> Pseudos { get; init; }

    public static bool IsEquals(CssClassInfo a, CssClassInfo b)
    {
        if (a.Name != b.Name)
        {
            return false;
        }

        if (a.ComponentUniqueIdentifier != b.ComponentUniqueIdentifier)
        {
            return false;
        }

        // compare Pseudos
        {
            if (a.Pseudos is not null && b.Pseudos is null)
            {
                return false;
            }

            if (a.Pseudos is null && b.Pseudos is not null)
            {
                return false;
            }

            if (a.Pseudos is not null && b.Pseudos is not null)
            {
                if (a.Pseudos.Count != b.Pseudos.Count)
                {
                    return false;
                }

                for (var i = 0; i < a.Pseudos.Count; i++)
                {
                    if (a.Pseudos[i].Name != b.Pseudos[i].Name)
                    {
                        return false;
                    }

                    if (a.Pseudos[i].BodyOfCss != b.Pseudos[i].BodyOfCss)
                    {
                        return false;
                    }
                }
            }
        }

        // compare MediaQueries
        {
            if (a.MediaQueries is not null && b.MediaQueries is null)
            {
                return false;
            }

            if (a.MediaQueries is null && b.MediaQueries is not null)
            {
                return false;
            }

            if (a.MediaQueries is not null && b.MediaQueries is not null)
            {
                if (a.MediaQueries.Count != b.MediaQueries.Count)
                {
                    return false;
                }

                for (var i = 0; i < a.MediaQueries.Count; i++)
                {
                    if (a.MediaQueries[i].mediaRule != b.MediaQueries[i].mediaRule)
                    {
                        return false;
                    }

                    if (a.MediaQueries[i].cssBody != b.MediaQueries[i].cssBody)
                    {
                        return false;
                    }
                }
            }
        }

        return true;
    }

    public void WriteTo(JsonMap jsonMap)
    {
        if (Pseudos is not null)
        {
            foreach (var pseudoCodeInfo in Pseudos)
            {
                var cssSelector = $".{Name}:{pseudoCodeInfo.Name}";
                var cssBody     = pseudoCodeInfo.BodyOfCss;

                jsonMap.Add(cssSelector, cssBody);
            }
        }

        if (MediaQueries != null)
        {
            foreach (var (mediaRule, cssBody) in MediaQueries)
            {
                var cssSelector = $"@media {mediaRule} {{ .{Name}";

                jsonMap.Add(cssSelector, cssBody);
            }
        }
    }
}