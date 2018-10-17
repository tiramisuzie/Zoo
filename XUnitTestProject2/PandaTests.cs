using Xunit;
using Zoo.Classes;

namespace XUnitTestProject2
{
    public class PandaTests
    {
        [Fact]
        public void ShouldReturnCorrectHungerLevel()
        {
            Panda panda = new Panda();
            var result = panda.Eat();
            Assert.Equal(0, result);
        }

        [Fact]
        public void ShouldReturnCorrectCutenessLevel()
        {
            Panda panda = new Panda();
            var result = panda.Attack();
            Assert.Equal(1, result);
        }
    }
}
