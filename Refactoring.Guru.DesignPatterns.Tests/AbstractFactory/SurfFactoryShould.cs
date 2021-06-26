using NUnit.Framework;
using Refactoring.Guru.DesignPatterns.AbstractFactory;

namespace Refactoring.Guru.DesignPatterns.Tests.AbstractFactory
{
    [TestFixture]
    public class SurfFactoryShould
    {
        private IGenreFactory _factory;

        [SetUp]
        public void Init()
        {
            //arrange
            _factory = new SurfFactory();
        }

        [Test]
        public void CreateJazzmaster()
        {
            //act
            var guitar = _factory.CreateGuitar();

            //assert
            Assert.IsInstanceOf<Jazzmaster>(guitar);
        }

        [Test]
        public void CreateTwinReverb()
        {
            //act
            var amp = _factory.CreateAmplifier();

            //assert
            Assert.IsInstanceOf<TwinReverb>(amp);
        }
    }
}
