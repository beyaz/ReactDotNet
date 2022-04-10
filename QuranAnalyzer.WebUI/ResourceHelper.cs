﻿using System;
using System.IO;
using System.Text.Json;
using QuranAnalyzer.WebUI.Pages.FactPage;
using YamlDotNet.Serialization;

namespace QuranAnalyzer.WebUI;

static class ResourceHelper
{
    public static T Read<T>(string fileName)
    {
        var fileData = readResource("QuranAnalyzer.WebUI." + fileName);

        if (fileName.EndsWith(".yaml"))
        {
            return new DeserializerBuilder().Build().Deserialize<T>(fileData);
        }

        return JsonSerializer.Deserialize<T>(fileData);

        static string readResource(string resourcePath)
        {
            using Stream stream = typeof(FactModel).Assembly.GetManifestResourceStream(resourcePath);

            using StreamReader reader = new StreamReader(stream ?? throw new InvalidOperationException());

            return reader.ReadToEnd();
        }
    }

    public static T ReadPage<T>(string pageName) => Read<T>($"Resources.{pageName}.yaml");
}