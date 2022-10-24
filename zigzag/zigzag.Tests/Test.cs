using FluentAssertions;

namespace zigzag.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        // Arrange
        var sut = new Solution();
        
        // Act
        var result = sut.zigzag("PAYPALISHIRING", 3);

        // Assert
        result.Should().Be("PAHNAPLSIIGYIR");
    }
    
    [Fact]
    public void Test2()
    {
        // Arrange
        var sut = new Solution();
        
        // Act
        var result = sut.zigzag("PAYPALISHIRING", 4);

        // Assert
        result.Should().Be("PINALSIGYAHRPI");
    }
}