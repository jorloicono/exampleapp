using Xunit;

namespace AzureDotNetApp.Tests;

public class BasicTests
{
    [Fact]
    public void ReturnsExpectedValue()
    {
        Assert.Equal(2, 1 + 1);
    }
}
