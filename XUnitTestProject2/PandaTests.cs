using Xunit;
using Zoo.Classes;

namespace XUnitTestProject2
{
    public class PandaTests
    {
        [Fact]
        public void ShouldReturnEatInHerbivorelevel()
        {
            Panda panda = new Panda();
            var result = panda.Eat();
            Assert.Equal("I eat vegetable", result);
        }

        [Fact]
        public void ShouldReturnHealthInAnimalLevel()
        {
            Panda panda = new Panda();
            var result = panda.Health();
            Assert.Equal(100, result);
        }

        [Fact]
        public void ShouldReturnNapInISleep()
        {
            Panda panda = new Panda();
            var result = panda.Nap();
            Assert.Equal("ZZZZZZ", result);
        }

        [Fact]
        public void ShouldReturnAsleepInISleep()
        {
            Panda panda = new Panda();
            var result = panda.Asleep;
            Assert.True(result);
        }
    }
}
