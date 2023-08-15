using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Net.Http.Headers;
using ReactWithDotNet.UIDesigner;
using ReactWithDotNet.WebSite.HelperApps;

namespace ReactWithDotNet.WebSite;

static class ReactWithDotNetIntegration
{
    public static void ConfigureReactWithDotNet(this IEndpointRouteBuilder endpoints)
    {
        endpoints.MapGet("/", HomePage);
        endpoints.MapPost("/" + nameof(HandleReactWithDotNetRequest), HandleReactWithDotNetRequest);

        endpoints.MapGet("/LiveEditor", async httpContext =>
        {
            await WriteHtmlResponse(httpContext, new MainLayout
            {
                Page = new HtmlToCSharpView()
            });
        });

#if DEBUG // this two endpoints should use only development mode

        endpoints.MapGet("/" + nameof(ReactWithDotNetDesigner), async httpContext =>
        {
            ReactWithDotNetDesigner.IsAttached = true;

            await WriteHtmlResponse(httpContext, new MainLayout
            {
                Page = new ReactWithDotNetDesigner()
            });
        });
        endpoints.MapGet("/" + nameof(ReactWithDotNetDesignerComponentPreview), async httpContext =>
        {
            ReactWithDotNetDesigner.IsAttached = true;

            await WriteHtmlResponse(httpContext, new MainLayout
            {
                Page = new ReactWithDotNetDesignerComponentPreview()
            });
        });
#endif
    }

    static async Task HandleReactWithDotNetRequest(HttpContext httpContext)
    {
        httpContext.Response.ContentType = "application/json; charset=utf-8";

        var jsonText = await CalculateRenderInfo(new CalculateRenderInfoInput
        {
            HttpContext           = httpContext,
            OnReactContextCreated = InitializeTheme
        });

        await httpContext.Response.WriteAsync(jsonText);
    }

    static async Task HomePage(HttpContext httpContext)
    {
        await WriteHtmlResponse(httpContext, new MainLayout
        {
            Page = new MainWindow()
        });
    }

    static Task InitializeTheme(HttpContext httpContext, ReactContext context)
    {
        context.Set(ThemeKey, new LightTheme());
        return Task.CompletedTask;
    }

    static async Task WriteHtmlResponse(HttpContext httpContext, MainLayout mainLayout)
    {
        httpContext.Response.ContentType = "text/html; charset=UTF-8";

        httpContext.Response.Headers[HeaderNames.CacheControl] = "no-cache, no-store, must-revalidate";
        httpContext.Response.Headers[HeaderNames.Expires]      = "0";
        httpContext.Response.Headers[HeaderNames.Pragma]       = "no-cache";

        mainLayout.RenderInfo = await CalculateComponentRenderInfo(new CalculateComponentRenderInfoInput
        {
            Component             = mainLayout.Page,
            HttpContext           = httpContext,
            QueryString           = httpContext.Request.QueryString.ToString(),
            OnReactContextCreated = InitializeTheme
        });

        var html = await CalculateComponentHtmlText(new CalculateComponentHtmlTextInput
        {
            HttpContext           = httpContext,
            Component             = mainLayout,
            QueryString           = httpContext.Request.QueryString.ToString(),
            OnReactContextCreated = InitializeTheme
        });

        await httpContext.Response.WriteAsync(html);
    }
}