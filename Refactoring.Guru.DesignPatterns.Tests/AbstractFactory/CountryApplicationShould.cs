using NUnit.Framework;
using Refactoring.Guru.DesignPatterns.AbstractFactory;

namespace Refactoring.Guru.DesignPatterns.Tests.AbstractFactory
{
    [TestFixture]
    public class CountryApplicationShould
    {
        private Application _app;

        [SetUp]
        public void Init()
        {
            //arrange
            _app = new Application("country");
        }

        [Test]
        public void HaveTelecaster()
        {
            //act
            var guitar = _app.GetGuitar();


            //assert
            Assert.IsInstanceOf<Telecaster>(guitar);
        }

        [Test]
        public void HaveHotRodDeluxe()
        {
            //act
            var amp = _app.GetAmplifier();

            //assert
            Assert.IsInstanceOf<HotRodDeluxe>(amp);
        }
    }
}
