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
    }
}
