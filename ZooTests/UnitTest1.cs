using System;
using Xunit;
using Zoo.Classes;

namespace ZooTests
{
    public class LionTests
    {
        [Fact]
        public void ShouldHunt()
        {
            Lion lionel = new Lion();

            Assert.Equal(" stalks it's prey", lionel.Hunt());
        }

        [Fact]
        public void ShouldMove()
        {
            Lion lionel = new Lion();

            Assert.Equal(" runs through the tall grass", lionel.Move());
        }
    }

    public class TigerTests
    {
        [Fact]
        public void ShouldHunt()
        {
            Tiger tigerel = new Tiger();

            Assert.Equal(" jumps on it's prey from above", tigerel.Hunt());
        }

        [Fact]
        public void ShouldMove()
        {
            Tiger tigerel = new Tiger();

            Assert.Equal(" walks assuredly", tigerel.Move());
        }

        [Fact]
        public void ShouldInheritSleep()
        {
            Tiger tigerel = new Tiger();

            Assert.Equal(" sleeps for 8 hours", tigerel.Sleep());
        }
    }

    public class BearTests
    {
        [Fact]
        public void ShouldHunt()
        {
            Bear teddionel = new Bear();

            Assert.Equal(" goes fishing", teddionel.Hunt());
        }

        [Fact]
        public void ShouldMove()
        {
            Bear teddionel = new Bear();

            Assert.Equal(" lumbers thorugh the forest", teddionel.Move());
        }

        [Fact]
        public void ShouldImplementInterface()
        {
            Bear teddionel = new Bear();

            Assert.Equal(" is breathing deeply", teddionel.Breath());
        }

        [Fact]
        public void ShouldOverrideSleepMethod()
        {
            Bear teddionel = new Bear();
            Lion lionel = new Lion();

            Assert.True(lionel.Sleep() != teddionel.Sleep());
        }


    }

    public class CrocodileTests
    {
        [Fact]
        public void ShouldHunt()
        {
            Crocodile crocionel = new Crocodile();

            Assert.Equal(" waits patiently for an unsuspecting victim in the water", crocionel.Hunt());
        }

        [Fact]
        public void ShouldMove()
        {
            Crocodile crocionel = new Crocodile();

            Assert.Equal(" swims quietly through the water", crocionel.Move());
        }
    }

    public class VelociraptorTests
    {
        [Fact]
        public void ShouldHunt()
        {
            Velociraptor velocionel = new Velociraptor();

            Assert.Equal(" waits for it's prey to stop moving", velocionel.Hunt());
        }

        [Fact]
        public void ShouldMove()
        {
            Velociraptor velocionel = new Velociraptor();

            Assert.Equal(" hops over tables and stairs", velocionel.Move());
        }
    }
}
