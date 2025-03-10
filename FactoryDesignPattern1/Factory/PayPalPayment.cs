namespace FactoryDesignPattern1.Factory
{
    public class PayPalPayment : IPaymentGateway
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing ${amount} payment via PayPal.");
        }
    }

    public class CreditCardPayment : IPaymentGateway
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing ${amount} payment via Credit Card.");
        }
    }

    public class UpiPayment : IPaymentGateway
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing ${amount} payment via UPI.");
        }
    }
}
