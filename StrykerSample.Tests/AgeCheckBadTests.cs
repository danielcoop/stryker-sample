namespace StrykerSample.Tests;

public class AgeCheckBadTests
{
    [Fact]
    public void IsUserOldEnough_Should_BeTrue_If_18()
    {
        var value = AgeCheck.IsUserOldEnough(19);

        value.Should().BeTrue();
    }


    // Comment out the above implementation and replace with below to have better test coverage
    /*[Theory]
    [InlineData(18)]
    [InlineData(19)]
    public void IsUserOldEnough_Should_BeTrue_If_18OrOlder(int inputAge)
    {
        var value = AgeCheck.IsUserOldEnough(inputAge);

        value.Should().BeTrue();
    }

    [Fact]
    public void IsUserOldEnough_Should_BeFalse_If_Under18()
    {
        var value = AgeCheck.IsUserOldEnough(17);

        value.Should().BeFalse();
    }*/
}
