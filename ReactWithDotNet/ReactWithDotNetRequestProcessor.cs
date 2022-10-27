﻿using System.Text;
using Microsoft.AspNetCore.Http;

namespace ReactWithDotNet;

public sealed class ProcessReactWithDotNetRequestInput
{
    internal ComponentRequest componentRequest;

    internal Func<string, Type> findType;

    public Action<Element, ReactContext> BeforeSerializeElementToClient { get; set; }

    public HttpContext HttpContext { get; set; }


    public Action<ReactContext> OnReactContextCreated { get; set; }
}

public static class ReactWithDotNetRequestProcessor
{
    public static async Task ProcessReactWithDotNetRequest(ProcessReactWithDotNetRequestInput input)
    {
        var httpContext = input.HttpContext;

        input.componentRequest = await readJson();

        input.findType = Type.GetType;

        var response = ComponentRequestHandler.HandleRequest(input);

        httpContext.Response.ContentType = "application/json";

        await httpContext.Response.WriteAsync(response.ToJson());

        async Task<ComponentRequest> readJson()
        {
            using var reader = new StreamReader(httpContext.Request.Body, Encoding.UTF8, true, 1024, true);

            return DeserializeJson<ComponentRequest>(await reader.ReadToEndAsync());
        }
    }
}