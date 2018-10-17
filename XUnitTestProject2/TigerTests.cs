using Xunit;
using Zoo.Classes;

namespace XUnitTestProject2
{
    public class WolfTests
    {
        [Fact]
        public void ShouldReturnCorrectBiteLevel()
        {
            Fox fox = new Fox();
            var result = fox.Bite;
            Assert.Equal(50, result);
        }

        [Fact]
        public void ShouldReturnCorrectTeethLevel()
        {
            Fox fox = new Fox();
            var result = fox.Teeth;
            Assert.Equal(25, result);
        }
    }
}
