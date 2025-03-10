using FactoryDesignPattern1.Factory;

namespace FactoryDesignPattern1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Register payment gateways
            builder.Services.AddTransient<PayPalPayment>();
            builder.Services.AddTransient<CreditCardPayment>();
            builder.Services.AddTransient<UpiPayment>();

            // Register Factory as Singleton
            builder.Services.AddSingleton<IPaymentGatewayFactory, PaymentGatewayFactory>();


            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}