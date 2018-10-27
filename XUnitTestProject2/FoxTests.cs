using Xunit;
using Zoo.Classes;

namespace XUnitTestProject2
{
    public class FoxTests
    {
        [Fact]
        public void ShouldReturnEatInCarnivoreLevel()
        {
            Fox fox = new Fox();
            var result = fox.Eat();
            Assert.Equal("I eat meat", result);
        }

        [Fact]
        public void ShouldReturnHealthInAnimalLevel()
        {
            Fox fox = new Fox();
            var result = fox.Health();
            Assert.Equal(100, result);
        }

        [Fact]
        public void ShouldReturnEnergyInIHunt()
        {
            Fox fox = new Fox();
            var result = fox.Energy;
            Assert.Equal(50, result);
        }

        [Fact]
        public void ShouldReturnWeaponInIHunt()
        {
            Fox fox = new Fox();
            var result = fox.Weapon();
            Assert.Equal("teeth and claws", result);
        }
    }
}
