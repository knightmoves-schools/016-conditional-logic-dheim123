namespace Tests;
using knightmoves;
using Xunit;

public class AutogradingTest
{
    /*
should contain a method named `ValidateAge` that takes a parameter named `oldEnough` and returns "old enough" if `oldEnough` is true
- should return an empty string ("") from the `ValidateAge` method if `oldEnough` is false
    */
    [Fact]
    public void Should_Contain_A_Method_Named_ValidateAge_That_Takes_A_Parameter_Named_OldEnough_And_Returns_Old_Enough_If_OldEnough_Is_True(){
        var registration = new Registration();
        var result = registration.ValidateAge(true);
        Assert.Equal("old enough", result);
    }

    [Fact]
    public void Should_Return_An_Empty_String_From_The_ValidateAge_Method_If_OldEnough_Is_False(){
        var registration = new Registration();
        var result = registration.ValidateAge(false);
        Assert.Equal("", result);
    }
}