using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using ReactWithDotNet.UIDesigner;

namespace QuranAnalyzer.WebUI;

static class ReactWithDotNetIntegration
{
    public static void ConfigureReactWithDotNet(this IEndpointRouteBuilder endpoints)
    {
        endpoints.MapGet("/", HomePage);
        endpoints.MapPost($"/{nameof(HandleReactWithDotNetRequest)}", HandleReactWithDotNetRequest);
        endpoints.MapGet($"/{nameof(ReactWithDotNetDesigner)}", ReactWithDotNetDesigner);
        endpoints.MapGet($"/{nameof(ReactWithDotNetDesignerComponentPreview)}", ReactWithDotNetDesignerComponentPreview);
    }

    static async Task HandleReactWithDotNetRequest(HttpContext context)
    {
        var input = new ProcessReactWithDotNetRequestInput
        {
            HttpContext = context
        };
        await ReactWithDotNetRequestProcessor.ProcessReactWithDotNetRequest(input);
    }

    static async Task HomePage(HttpContext context)
    {
        await context.WriteHtmlResponse(new HtmlContentGenerator
        {
            TargetReactComponent = typeof(ReactWithDotNet.WebSite.MainWindow)
        });
    }

    static async Task ReactWithDotNetDesigner(HttpContext context)
    {
        await context.WriteHtmlResponse(new HtmlContentGenerator
        {
            TargetReactComponent = typeof(ReactWithDotNetDesigner),

            Stylesheets = new[]
            {
                "<link rel='stylesheet' href='https://cdn.jsdelivr.net/npm/primereact@8.2.0/resources/themes/saga-blue/theme.css'>",
                "<link rel='stylesheet' href='https://cdn.jsdelivr.net/npm/primereact@8.2.0/resources/primereact.min.css'>",
                "<link rel='stylesheet' href='https://cdn.jsdelivr.net/npm/primeicons@5.0.0/primeicons.css'>"
            }
        });
    }

    static async Task ReactWithDotNetDesignerComponentPreview(HttpContext context)
    {
        await context.WriteHtmlResponse(new HtmlContentGenerator
        {
            TargetReactComponent = typeof(ReactWithDotNetDesignerComponentPreview)
        });
    }

    static async Task WriteHtmlResponse(this HttpContext context, HtmlContentGenerator htmlContentGenerator)
    {
        context.Response.ContentType = "text/html; charset=UTF-8";

        var htmlContent = htmlContentGenerator.GetHtmlContent();

        await context.Response.WriteAsync(htmlContent);
    }
}