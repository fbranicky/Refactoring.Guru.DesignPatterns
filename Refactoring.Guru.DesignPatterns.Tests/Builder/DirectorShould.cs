using NUnit.Framework;
using Refactoring.Guru.DesignPatterns.Builder;

namespace Refactoring.Guru.DesignPatterns.Tests.Builder
{
    [TestFixture]
    public class DirectorShould
    {
        private Director _director;
        private GuitarBuilder _builder;

        [SetUp]
        public void Init()
        {
            //arrange
            _director = new Director();
            _builder = new GuitarBuilder();
            _director.GuitarBuilder = _builder;
        }

        [Test]
        public void BuildATelecaster()
        {
            //act
            _director.ConstructTelecaster();
            var guitar = _builder.GetGuitar();

            //assert
            Assert.AreEqual("Telecaster", guitar.Name);
        }

        [Test]
        public void BuildATroublemaker()
        {
            //act
            _director.ConstructTroublemaker();
            var guitar = _builder.GetGuitar();

            //assert
            Assert.AreEqual("Troublemaker", guitar.Name);
        }
    }
}
