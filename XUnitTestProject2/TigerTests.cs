using Xunit;
using Zoo.Classes;

namespace XUnitTestProject2
{
    public class WolfTests
    {
        [Fact]
        public void ShouldReturnAgeInAnimalLevel()
        {
            Tiger tiger = new Tiger();
            var result = tiger.age;
            Assert.Equal(9000, result);
        }

        [Fact]
        public void ShouldReturnSuperPowerInAnimalLevel()
        {
            Tiger tiger = new Tiger();
            var result = tiger.SuperPower();
            Assert.Equal("Magic", result);
        }
    }
}
