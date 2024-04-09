using System.Reflection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Net.Http.Headers;
using ReactWithDotNet.UIDesigner;

namespace ReactWithDotNet.WebSite;

public static class ReactWithDotNetIntegration
{
    public static void ConfigureReactWithDotNet(this WebApplication app)
    {
        var map = typeof(Page)
            .GetProperties(BindingFlags.Static | BindingFlags.Public)
            .Where(p => p.PropertyType == typeof(PageRouteInfo))
            .Select(p => (PageRouteInfo)p.GetValue(null))
            .Where(x => x is not null)
            .ToDictionary(x => x.Url, x => x, StringComparer.OrdinalIgnoreCase);

        app.Use(async (httpContext, next) =>
        {
            var path = httpContext.Request.Path.Value ?? string.Empty;

            if (path == $"/{nameof(HandleReactWithDotNetRequest)}")
            {
                await HandleReactWithDotNetRequest(httpContext);
                return;
            }

            if (map.TryGetValue(path, out var routeInfo))
            {
                await WriteHtmlResponse(httpContext, typeof(MainLayout), routeInfo.page);
                return;
            }

            if (path.StartsWith(Page.DocDetail.Url))
            {
                await WriteHtmlResponse(httpContext, typeof(MainLayout), Page.DocDetail.page);
                return;
            }

#if DEBUG
            if (path == $"/{nameof(ReactWithDotNetDesigner)}")
            {
                await WriteHtmlResponse(httpContext, typeof(MainLayout), typeof(ReactWithDotNetDesigner));
                return;
            }

            if (path == $"/{nameof(ReactWithDotNetDesignerComponentPreview)}")
            {
                await WriteHtmlResponse(httpContext, typeof(MainLayout), typeof(ReactWithDotNetDesignerComponentPreview));
                return;
            }
#endif

            await next();
        });
    }

    static Task HandleReactWithDotNetRequest(HttpContext httpContext)
    {
        httpContext.Response.ContentType = "application/json; charset=utf-8";

        return ProcessReactWithDotNetComponentRequest(new()
        {
            HttpContext           = httpContext,
            OnReactContextCreated = OnReactContextCreated
        });
    }

    static Task OnReactContextCreated(HttpContext httpContext, ReactContext context)
    {
        context.Set(ThemeKey, new());

        KeyForHttpContext[context] = httpContext;

        return Task.CompletedTask;
    }

    static Task WriteHtmlResponse(HttpContext httpContext, Type layoutType, Type mainContentType)
    {
        httpContext.Response.ContentType = "text/html; charset=UTF-8";

        httpContext.Response.Headers[HeaderNames.CacheControl] = "no-cache, no-store, must-revalidate";
        httpContext.Response.Headers[HeaderNames.Expires]      = "0";
        httpContext.Response.Headers[HeaderNames.Pragma]       = "no-cache";

        return ProcessReactWithDotNetPageRequest(new()
        {
            LayoutType            = layoutType,
            MainContentType       = mainContentType,
            HttpContext           = httpContext,
            QueryString           = httpContext.Request.QueryString.ToString(),
            OnReactContextCreated = OnReactContextCreated
        });
    }
}