﻿using System.IO;

namespace ReactWithDotNet.WebSite;

static partial class Extensions
{
    public static string text_primary => "#1A2027";
    
    public static readonly ReactContextKey<LightTheme> ThemeKey = new(nameof(ThemeKey));

    public static Modifier GetPageLink(string pageName) => Href($"/?p={pageName}");



    public static StyleModifier BorderRadiusForPaper => BorderRadius(4);

    public static StyleModifier DisplayNoneWhenMobile => WhenMediaSizeLessThan(MD,DisplayNone);
    public static StyleModifier DisplayNoneWhenNotMobile => MD(DisplayNone);
    

   


    
    
    public static string GetArticleHtmlContent(string filePathInContentFolder)
    {
        var path = Path.Combine("Content", filePathInContentFolder);

        return File.ReadAllText(path);
    }

    public static List<B> ToListOf<A, B>(this IEnumerable<A> enumerable, Func<A, B> convert)
    {
        if (enumerable == null)
        {
            throw new ArgumentNullException(nameof(enumerable));
        }

        if (convert == null)
        {
            throw new ArgumentNullException(nameof(convert));
        }

        return enumerable.Select(convert).ToList();
    }

    static readonly Dictionary<string, PureComponent> svgFileCache = new();
    
    public static PureComponent GetSvgByClassName(string className)
    {
        className = className.Replace(".svg","");
        
        if (svgFileCache.TryGetValue(className, out var instance))
        {
            return instance;
        }
        
        var type = typeof(Extensions).Assembly.GetType($"ReactWithDotNet.WebSite.SvgFiles.{className}",false);
        if (type == null)
        {
            throw new TypeLoadException(className);
        }
        
        instance = (PureComponent)Activator.CreateInstance(type);

        svgFileCache.TryAdd(className, instance);


        return instance;
    }

    public static Style ContainerStyle => new()
    {
        WidthFull,
        MaxWidth(1200),
        DisplayFlexRow,
        JustifyContentCenter,

        PaddingLeftRight(24)
    };


    public static Style PrimaryButtonStyle => new()
    {
        backgroundImage = "linear-gradient(to right, #DA22FF 0%, #9733EE  51%, #DA22FF  100%)",
        padding         = "15px 45px",
        textAlign       = "center",
        transition      = "0.5s",
        backgroundSize  = "200% auto",
        color           = "white",
        boxShadow       = "0 0 20px #eee",
        borderRadius    = "10px",

        textDecoration = "none",

        hover =
        {
            backgroundPosition = "right center",

        }
    };

}