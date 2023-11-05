using Learn.Verify.Xunit.Controllers;
using Xunit;
using VerifyTests;

namespace Learn.Verify.Xunit.Test;

[UsesVerify]
public class VerifyTest
{
    [Fact]
    public Task Test()
    {
        var controller = new WeatherForecastController(null);

        var result = controller.Get();

        return Verifier.Verify(result);
    }
}
