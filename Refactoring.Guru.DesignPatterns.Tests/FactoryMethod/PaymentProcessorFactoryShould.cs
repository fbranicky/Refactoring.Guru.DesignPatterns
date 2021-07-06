using NUnit.Framework;
using Refactoring.Guru.DesignPatterns.FactoryMethod;

namespace Refactoring.Guru.DesignPatterns.Tests.FactoryMethod
{
    [TestFixture]
    public class PaymentProcessorFactoryShould
    {
        PaymentProcessorFactory _paymentProcessorFactory;

        [SetUp]
        public void Init()
        {
            //arrange
            _paymentProcessorFactory = new PaymentProcessorFactory();
        }

        [Test]
        public void CreateCashProcessor()
        {
            //act
            var processor = _paymentProcessorFactory.GetPaymentProcessor(PaymentProcessorFactory.PaymentProcessorType.Cash);

            //assert
            Assert.IsInstanceOf<CashProcessor>(processor);
        }

        [Test]
        public void CreateStripeProcessor()
        {
            //act
            var processor = _paymentProcessorFactory.GetPaymentProcessor(PaymentProcessorFactory.PaymentProcessorType.Stripe);

            //assert
            Assert.IsInstanceOf<StripeProcessor>(processor);
        }
    }
}
