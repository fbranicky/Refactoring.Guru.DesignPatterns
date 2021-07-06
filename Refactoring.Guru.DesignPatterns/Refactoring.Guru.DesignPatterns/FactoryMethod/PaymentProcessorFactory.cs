using System;

namespace Refactoring.Guru.DesignPatterns.FactoryMethod
{
    /// <summary>
    /// A Factory Method allows for construction of new objects that
    /// implement the same interface.
    /// </summary>

    public class PaymentProcessorFactory
    {
        public IPaymentProcessor GetPaymentProcessor(PaymentProcessorType type)
        {
            switch (type)
            {
                case PaymentProcessorType.Cash:
                    return new CashProcessor();
                case PaymentProcessorType.Stripe:
                    return new StripeProcessor();
            }

            throw new ArgumentException("Unknown Payment Processor Type", "type");
        }

        public enum PaymentProcessorType
        {
            Cash,
            Stripe
        }
    }
}
