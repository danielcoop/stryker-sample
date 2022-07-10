namespace StrykerSample.Tests;

public class IsOpenBadImplTests
{
    [Fact]
    public void IsOpen_Should_BeTrue_If_TrueParameter()
    {
        var value = new IsOpenBadImpl("true");

        value.IsOpen.Should().BeTrue();
    }

    [InlineData("false")]
    [InlineData("blahblahblah")]
    [InlineData(null)]
    [Theory]
    public void IsOpen_Should_BeFalse_If_FalseOrInvalidParameter(string isOpenParameter)
    {
        var value = new IsOpenBadImpl(isOpenParameter);

        value.IsOpen.Should().BeFalse();
    }
}