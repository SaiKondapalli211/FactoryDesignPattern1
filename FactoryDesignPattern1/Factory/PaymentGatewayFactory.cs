namespace FactoryDesignPattern1.Factory
{
    public class PaymentGatewayFactory : IPaymentGatewayFactory
    {
        private readonly IServiceProvider _serviceProvider;

        public PaymentGatewayFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public IPaymentGateway CreatePaymentGateway(string type)
        {
            return type.ToLower() switch
            {
                "paypal" => _serviceProvider.GetRequiredService<PayPalPayment>(),
                "creditcard" => _serviceProvider.GetRequiredService<CreditCardPayment>(),
                "upi" => _serviceProvider.GetRequiredService<UpiPayment>(),
                _ => throw new ArgumentException("Invalid Payment Type")
            };

        }
    }
}
