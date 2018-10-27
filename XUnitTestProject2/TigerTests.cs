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

        [Fact]
        public void ShouldReturnNapInISleep()
        {
            Tiger tiger = new Tiger();
            var result = tiger.Nap();
            Assert.Equal("ZZZZZZ", result);
        }

        [Fact]
        public void ShouldReturnAsleepInISleep()
        {
            Tiger tiger = new Tiger();
            var result = tiger.Asleep;
            Assert.True(result);
        }
    }
}
