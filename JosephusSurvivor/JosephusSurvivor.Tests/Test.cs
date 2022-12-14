using System.Runtime.InteropServices;
using FluentAssertions;

namespace JosephusSurvivor.Tests;

public class UnitTest1
{
    [Theory]
    [InlineData(7,3,4)]
    [InlineData(11,19,10)]
    [InlineData(40,3,28)]
    [InlineData(14,2,13)]
    [InlineData(100,1,100)]
    [InlineData(1,300,1)]
    [InlineData(2,300,1)]
    [InlineData(5,300,1)]
    [InlineData(7,300,7)]
    [InlineData(300,300,265)]
    public void Test1(int numPeople, int step, int expected)
    {
        // Arrange
        var sut = new Solution();
        // Act
        var result = sut.JosephusSurvivor(numPeople, step);
        // Assert
        result.Should().Be(expected);
    }
}