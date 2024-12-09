using Country.Models;
using Country.Routes;

public class Program
{
    public static void Main(string[] args)
    {
        var build = WebApplication.CreateBuilder(args);
        build.Services.Configure<CountriesData>(build.Configuration.GetSection("CountriesData"));
        var app = build.Build();

        app.MapCountryRoutes();

        app.Run();
    }
}