using System;
using Xunit;
using Zoo.Classes;

namespace ZooTests
{
    public class LionTest
    {
        [Fact]
        public void ShouldHunt()
        {
            Lion lionel = new Lion();

            Assert.Equal("ROOAAAARRRR", lionel.Sounds());
        }
    }
}
