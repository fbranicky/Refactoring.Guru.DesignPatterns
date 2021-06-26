using NUnit.Framework;
using Refactoring.Guru.DesignPatterns.AbstractFactory;

namespace Refactoring.Guru.DesignPatterns.Tests.AbstractFactory
{
    [TestFixture]
    public class SurfApplicationShould
    {
        private Application _app;

        [SetUp]
        public void Init()
        {
            //arrange
            _app = new Application("surf");
        }

        [Test]
        public void HaveJazzmaster()
        {
            //act
            var guitar = _app.GetGuitar();


            //assert
            Assert.IsInstanceOf<Jazzmaster>(guitar);
        }

        [Test]
        public void HaveTwinReverb()
        {
            //act
            var amp = _app.GetAmplifier();

            //assert
            Assert.IsInstanceOf<TwinReverb>(amp);
        }
    }
}
