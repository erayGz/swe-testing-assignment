using QuickCalc.App;
using Xunit;

namespace QuickCalc.Tests;

public class AppIntegrationTests
{
    [Fact]
    public void Evaluate_5Plus3_Returns8()
        => Assert.Equal("8", QuickCalcEvaluator.Evaluate("5 + 3"));

    [Fact]
    public void Evaluate_DivideByZero_ReturnsERR()
        => Assert.Equal("ERR", QuickCalcEvaluator.Evaluate("5 / 0"));
}