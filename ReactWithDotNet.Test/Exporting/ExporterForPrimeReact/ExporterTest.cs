using System.Net.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ReactWithDotNet.Exporting.ExporterForPrimeReact;

[TestClass]
public class ExporterTest
{
    static string GetTsCode(string className)
    {
        var rawUrlInGithub = $"https://raw.githubusercontent.com/primefaces/primereact/master/components/lib/{className}/{className}.d.ts";

        return new HttpClient().GetStringAsync(rawUrlInGithub).GetAwaiter().GetResult();
    }
    
    
    [TestMethod]
    public void Splitter()
    {
        Exporter.ExportToCSharpFile(new ExportInput
        {
            DefinitionTsCode     = GetTsCode("splitter"),
            StartFrom            = "'ref'> {",
            ClassName            = "Splitter",
            SkipMembers          = new[] { "children", "onResizeEnd","pt" },
            IsContainer = true
        });
    }

    [TestMethod]
    public void SplitterPanel()
    {
        Exporter.ExportToCSharpFile(new ExportInput
        {
            DefinitionTsCode = GetTsCode("splitter"),
            StartFrom        = "interface SplitterPanelProps {",
            ClassName        = "SplitterPanel",
            SkipMembers      = new[] { "children", "style" },
            IsContainer      = true
        });
    }


}