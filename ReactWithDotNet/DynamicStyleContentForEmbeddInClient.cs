namespace ReactWithDotNet;

class DynamicStyleContentForEmbeddInClient
{
    internal readonly List<CssClassInfo> listOfClasses = new();

    public string GetClassName(CssClassInfo cssClassInfo)
    {
        foreach (var item in listOfClasses)
        {
            if (item.Pseudos.SequenceEqual(cssClassInfo.Pseudos))
            {
                return item.Name;
            }
        }

        // change name until is unique
        { 
            var suffix = 0;
            while (true)
            {
                if (listOfClasses.Any(x => x.Name == cssClassInfo.Name))
                {
                    cssClassInfo = new CssClassInfo
                    {
                        Name    = cssClassInfo.Name + suffix++,
                        Pseudos = cssClassInfo.Pseudos
                    };

                    continue;
                }
                break;
            }
        }
        
        listOfClasses.Add(cssClassInfo);

        return cssClassInfo.Name;
    }

    public string[] CalculateCssClassList()
    {
        if (!listOfClasses.Any())
        {
            return null;
        }

        return listOfClasses.Select(x => x.CalculateCssCode()).ToArray();
    }
}

class CssPseudoCodeInfo
{

    public string Name { get; init; }
    public string BodyOfCss { get; init; }

    public override bool Equals(object other)
    {
        if (other is CssPseudoCodeInfo info)
        {
            return info.Name == Name && info.BodyOfCss == BodyOfCss;
        }

        return false;
    }

    protected bool Equals(CssPseudoCodeInfo other)
    {
        return Name == other.Name && BodyOfCss == other.BodyOfCss;
    }

    public override int GetHashCode()
    {
        return (Name + ":" + BodyOfCss).GetHashCode();
    }
}

class CssClassInfo
{
    public string Name { get; init; }
    public IReadOnlyList<CssPseudoCodeInfo> Pseudos { get; init; }

    public string CalculateCssCode()
    {
        return string.Join(Environment.NewLine, Pseudos.Select(x => $".{Name}:{x.Name} {{ {x.BodyOfCss} }}"));
    }
}