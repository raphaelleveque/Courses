using Microsoft.AspNetCore.Builder;
namespace Controllers;

class Program
{
    static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddControllers();
        builder.Services.Configure<BankingOptions>(builder.Configuration.GetSection("bankAccount"));
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        
        var app = builder.Build();
        app.UseSwagger();
        app.UseSwaggerUI();
        app.UseRouting();
        app.MapControllers();
        app.Run();
    }

}