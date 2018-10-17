using Xunit;
using Zoo.Classes;

namespace XUnitTestProject2
{
    public class TigerTests
    {
        [Fact]
        public void ShouldReturnCorrectBiteLevel()
        {
            Tiger tiger = new Tiger();
            var result = tiger.Bite;
            Assert.Equal(9000, result);
        }

        [Fact]
        public void ShouldReturnCorrectTeethLevel()
        {
            Tiger tiger = new Tiger();
            var result = tiger.Teeth;
            Assert.Equal(9000, result);
        }
    }
}
