namespace FactoryDesignPattern1.Factory
{
    public interface IPaymentGatewayFactory
    {
        IPaymentGateway CreatePaymentGateway(string type);
    }
}
