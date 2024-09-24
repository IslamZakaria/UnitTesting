using Xunit;

namespace CalculatorLibrary.Tests.Unit;

public class CalculatorTests
{
    private readonly Calculator _sut = new();

    [Theory]
    [InlineData(5, 4, 9)]
    [InlineData(0, 0, 0)]
    [InlineData(-5, -10, -15)]
    public void Add_ShouldAddTwoNumbers_WhenTwoNumbersAreIntegers(
        int a, int b, int expected)
    {
        //Act
        var result = _sut.Add(a, b);

        //Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(10, 5, 5)]
    [InlineData(0, 0, 0)]
    [InlineData(-5, -5, 0)]
    public void Subtract_ShouldSubtractTwoNumbers_WhenTwoNumbersAreIntegers(
        int a, int b, int expected)
    {
        //Act
        var result = _sut.Subtract(a, b);

        //Assert
        Assert.Equal(expected, result);
    }
}
