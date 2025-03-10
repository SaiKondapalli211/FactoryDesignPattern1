using FactoryDesignPattern1.Factory;
using Microsoft.AspNetCore.Mvc;

namespace FactoryDesignPattern1.Controllers
{
    [ApiController]
    [Route("api/payment")]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentGatewayFactory _paymentFactory;

        public PaymentController(IPaymentGatewayFactory paymentFactory)
        {
            _paymentFactory = paymentFactory;
        }

        [HttpPost("{type}")]
        public IActionResult ProcessPayment(string type)
        {
            try
            {
                var paymentGateway = _paymentFactory.CreatePaymentGateway(type);
                paymentGateway.ProcessPayment(150.00m);
                return Ok($"Payment processed via {type}");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }

}