using Xunit;
using Zoo.Classes;

namespace XUnitTestProject2
{
    public class TigerTests
    {
        [Fact]
        public void ShouldReturnCutnessInPanda()
        {
            Youkai youkai = new Youkai();
            var result = youkai.Cutness;
            Assert.Equal(1000, result);
        }

        [Fact]
        public void ShouldReturnStrengthInAnimal()
        {
            Youkai youkai = new Youkai();
            var result = youkai.Strength;
            Assert.Equal(0, result);
        }

        [Fact]
        public void ShouldReturnEnergyInIHunt()
        {
            Youkai youkai = new Youkai();
            var result = youkai.Energy;
            Assert.Equal(1000, result);
        }

        [Fact]
        public void ShouldReturnWeaponInIHunt()
        {
            Youkai youkai = new Youkai();
            var result = youkai.Weapon();
            Assert.Equal("Energy Blast", result);
        }

        [Fact]
        public void ShouldReturnNapInISleep()
        {
            Youkai youkai = new Youkai();
            var result = youkai.Nap();
            Assert.Equal("I am sleeping", result);
        }

        [Fact]
        public void ShouldReturnAsleepInISleep()
        {
            Youkai youkai = new Youkai();
            var result = youkai.Asleep;
            Assert.True(result);
        }

        [Fact]
        public void IsAnAnimal()
        {
            Youkai youkai = new Youkai();
            var result = youkai.Strength;
            Assert.Equal(0, result);

            result = youkai.Int;
            Assert.Equal(0, result);
        }
    }
}
