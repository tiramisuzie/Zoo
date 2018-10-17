using System;
using Xunit;

namespace XUnitTestProject1
{
    public class PandaTests
    {
        [Fact]
        public void pandaCutness()
        {
            Panda panda = new Panda();
            panda.Eat();
        }
    }
}
