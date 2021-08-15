using NUnit.Framework;
using Refactoring.Guru.DesignPatterns.Prototype;

namespace Refactoring.Guru.DesignPatterns.Tests.Prototype
{
    [TestFixture]
    public class ShallowCopyShould
    {
        [Test]
        public void CloneMembers()
        {
            //arrange
            var g1 = new Guitar(123);
            g1.Name = "Telecaster";
            g1.Pickups = new Guitar.PickupConfiguration { Quantity = 2 };

            //act
            var g2 = g1.ShallowCopy();

            //assert
            Assert.AreEqual(g1.Name, g2.Name); //public
            Assert.AreEqual(g1.GetMsrp(), g2.GetMsrp()); //private
            Assert.AreEqual(g1.Pickups.Quantity, g2.Pickups.Quantity); //child object
        }

        [Test]
        public void UseSameReferenceTypeObjects()
        {
            //arrange
            var g1 = new Guitar(123);
            g1.Name = "Telecaster";
            g1.Pickups = new Guitar.PickupConfiguration { Quantity = 2 };

            //act
            var g2 = g1.ShallowCopy();
            g1.Pickups.Quantity = 3;

            //assert
            Assert.AreEqual(g1.Pickups.Quantity, g2.Pickups.Quantity);
        }
    }
}
