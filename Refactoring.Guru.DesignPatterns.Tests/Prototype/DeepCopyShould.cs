using NUnit.Framework;
using Refactoring.Guru.DesignPatterns.Prototype;


namespace Refactoring.Guru.DesignPatterns.Tests.Prototype
{
    [TestFixture]
    public class DeepCopyShould
    {
        [Test]
        public void UseNewReferenceTypeObjects()
        {
            //arrange
            var g1 = new Guitar(123);
            g1.Name = "Telecaster";
            g1.Pickups = new Guitar.PickupConfiguration { Quantity = 2 };

            //act
            var g2 = g1.DeepCopy();
            g1.Pickups.Quantity = 3; //change source object

            //assert
            Assert.AreNotEqual(g1.Pickups.Quantity, g2.Pickups.Quantity);
        }
    }
}
