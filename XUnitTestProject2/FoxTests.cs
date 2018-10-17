using Xunit;
using Zoo.Classes;

namespace XUnitTestProject2
{
    public class FoxTests
    {
        [Fact]
        public void ShouldReturnCorrectAttackLevel()
        {
            Fox fox = new Fox();
            var result = fox.Attack();
            Assert.Equal(1250, result);
        }

        [Fact]
        public void ShouldReturnCorrectHungerLevel()
        {
            Fox fox = new Fox();
            var result = fox.Eat();
            Assert.Equal(25, result);
        }
    }
}
