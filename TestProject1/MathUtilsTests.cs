using Xunit;

namespace ConsoleApp1.Tests
{
    
    public class MathUtilsTests
    {
        [Fact]
        public void Add_ReturnsCorrectSum()
        {
            Assert.Equal(5, MathUtils.Add(2, 3));
        }

        [Fact]
        public void Subtract_ReturnsCorrectDifference()
        {
            Assert.Equal(1, MathUtils.Subtract(3, 2));
        }

        
        [Fact]
        public void multiply_ReturnsCorrectDifference()
        {
            Assert.Equal(6, MathUtils.Multiply(3, 2));
        }

    
    }

    
    public class StringUtilsTests
    {
        [Fact]
        public void Reverse_ReturnsReversedString()
        {
            Assert.Equal("tac", StringUtils.Reverse("cat"));
        }
    }
}
