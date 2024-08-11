using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReactWithDotNet.Tokenizing;

namespace ReactWithDotNet.Test;

[TestClass]
public class DesignerHelperTest
{
    [TestMethod]
    public void _0_()
    {
        const string inputCode = "Margin(1, 2, 3, 4), Margin(4), Padding(22.56), BackgroundWhite,  Background(\"yellow\")";
        const string expectedCode = "Margin(1, 2, 3, 4), Margin(4), Padding(22.56), BackgroundWhite, Background(\"yellow\")";

        Assert(inputCode, expectedCode);
    }
    
    [TestMethod]
    public void _1_()
    {
        const string inputCode = """

                                 BackgroundWhite, Padding(22.56), Background("yellow"),   WidthFitContent, Margin(5,8), Hover( Padding(56), Margin(7,8) )

                                 """;

        const string expectedCode = "BackgroundWhite, Padding(22.56), Background(\"yellow\"), WidthFitContent, Margin(5,8), Hover(Padding(56), Margin(7,8))";

        Assert(inputCode, expectedCode);
    }

    static void Assert(string inputCode, string expectedCode)
    {
        var (hasRead, _, tokens) = Lexer.ParseTokens(inputCode, 0);

        hasRead.Should().BeTrue();

        tokens = tokens.Where(x=>x.tokenType != TokenType.Space).ToList();

        var (success, nodes, i) = DesignerHelper.TryReadNodes(tokens,0,tokens.Count-1);
       
        success.Should().BeTrue();

        string.Join(", ", nodes).Should().Be(expectedCode);
    }
}