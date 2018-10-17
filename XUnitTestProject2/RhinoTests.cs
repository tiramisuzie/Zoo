using Xunit;
using Zoo.Classes;

namespace XUnitTestProject2
{
    public class RhinoTests
    {
        [Fact]
        public void ShouldReturnCorrectHungerLevel()
        {
            Rhino rhino = new Rhino();
            var result = rhino.Eat();
            Assert.Equal(50, result);
        }

        [Fact]
        public void ShouldReturnCorrectAttackLevel()
        {
            Rhino rhino = new Rhino();
            var result = rhino.Attack();
            Assert.Equal(1000, result);
        }
    }
}
