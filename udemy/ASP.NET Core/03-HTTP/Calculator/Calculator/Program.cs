using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.WebUtilities;

namespace Calculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.Run(async (context) =>
            {
                if (context.Request.Method.Equals("GET", StringComparison.OrdinalIgnoreCase))
                {
                    // Handle GET request: read from query string
                    var firstNumberStr = context.Request.Query["firstNumber"];
                    var secondNumberStr = context.Request.Query["secondNumber"];
                    var operation = context.Request.Query["operation"];

                    await HandleRequest(context, firstNumberStr, secondNumberStr, operation);
                }
                else if (context.Request.Method.Equals("POST", StringComparison.OrdinalIgnoreCase))
                {
                    // Handle POST request: read from request body
                    using (var reader = new StreamReader(context.Request.Body))
                    {
                        var body = await reader.ReadToEndAsync();

                        // Parse body content (assuming it's in query string format)
                        var bodyMapped = QueryHelpers.ParseQuery(body);

                        var firstNumberStr = bodyMapped["firstNumber"][0];
                        var secondNumberStr = bodyMapped["secondNumber"][0];
                        var operation = bodyMapped["operation"][0];

                        await HandleRequest(context, firstNumberStr, secondNumberStr, operation);
                    }
                }
                else
                {
                    context.Response.StatusCode = 405; // Method Not Allowed
                    await context.Response.WriteAsync("Method not supported.");
                }
            });

            app.Run();
        }

        private static async Task HandleRequest(HttpContext context, string? firstNumberStr, string? secondNumberStr, string? operation)
        {
            // Check if all parameters are provided
            if (string.IsNullOrEmpty(firstNumberStr) || string.IsNullOrEmpty(secondNumberStr) || string.IsNullOrEmpty(operation))
            {
                context.Response.StatusCode = 400;
                await context.Response.WriteAsync("Invalid input. All parameters (firstNumber, secondNumber, operation) are required.");
                return;
            }

            // Parse numbers
            if (!int.TryParse(firstNumberStr, out int firstNumber) || !int.TryParse(secondNumberStr, out int secondNumber))
            {
                context.Response.StatusCode = 400;
                await context.Response.WriteAsync("Invalid input for 'firstNumber' or 'secondNumber'. Please provide valid integers.");
                return;
            }

            // Perform calculation based on operation
            int result = 0;
            switch (operation.ToLower())
            {
                case "add":
                    result = firstNumber + secondNumber;
                    break;
                case "subtract":
                    result = firstNumber - secondNumber;
                    break;
                case "multiply":
                    result = firstNumber * secondNumber;
                    break;
                case "divide":
                    if (secondNumber == 0)
                    {
                        context.Response.StatusCode = 400;
                        await context.Response.WriteAsync("Division by zero is not allowed.");
                        return;
                    }
                    result = firstNumber / secondNumber;
                    break;
                case "modulo":
                    result = firstNumber % secondNumber;
                    break;
                default:
                    context.Response.StatusCode = 400;
                    await context.Response.WriteAsync($"Invalid input for {operation}. Supported operations are: add, subtract, multiply, divide, modulo.");
                    return;
            }

            // Return the result
            context.Response.StatusCode = 200;
            await context.Response.WriteAsync(result.ToString());
        }
    }
}
