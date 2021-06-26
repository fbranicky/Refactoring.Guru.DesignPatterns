using NUnit.Framework;
using Refactoring.Guru.DesignPatterns.AbstractFactory;

namespace Refactoring.Guru.DesignPatterns.Tests.AbstractFactory
{
    [TestFixture]
    public class CountryFactoryShould
    {
        private IGenreFactory _factory;

        [SetUp]
        public void Init()
        {
            //arrange
            _factory = new CountryFactory();
        }

        [Test]
        public void CreateTelecaster()
        {
            //act
            var guitar = _factory.CreateGuitar();

            //assert
            Assert.IsInstanceOf<Telecaster>(guitar);
        }

        [Test]
        public void CreateHotRodDeluxe()
        {
            //act
            var amp = _factory.CreateAmplifier();

            //assert
            Assert.IsInstanceOf<HotRodDeluxe>(amp);
        }
    }
}
