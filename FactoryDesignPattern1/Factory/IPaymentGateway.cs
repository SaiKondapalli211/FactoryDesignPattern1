namespace FactoryDesignPattern1.Factory
{
    public interface IPaymentGateway
    {
        void ProcessPayment(decimal amount);
    }
}
