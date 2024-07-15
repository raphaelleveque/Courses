namespace Middlewares;

public class ValidateUser
{
    private readonly RequestDelegate _next;

    public ValidateUser(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        string? email = null, password = null;
        if (context.Request.Method == "GET")
        {
            email = context.Request.Query["email"];
            password = context.Request.Query["password"];
        } 
        else if (context.Request.Method == "POST")
        {
            var form = await context.Request.ReadFormAsync();
            email = form["email"];
            password = form["password"];

        }

        if (email is null || password is null)
        {
            context.Response.StatusCode = 400;
            await context.Response.WriteAsync("Invalid credentials");
        } 
        else if (email == "admin@example.com" && password == "admin1234")
        {
            context.Response.StatusCode = 200;
            await context.Response.WriteAsync("Successful Login");
        }
        else
        {
            var errors = new List<string>();
            // Check for invalid email
            if (email != "admin@example.com")
            {
                errors.Add("Invalid input for 'email'");
            }

            // Check for invalid password
            if (password != "admin1234")
            {
                errors.Add("Invalid input for 'password'");
            }

            // If there are any errors, set the status code and write all errors to the response
            if (errors.Count > 0)
            {
                context.Response.StatusCode = 400;
                await context.Response.WriteAsync(string.Join("\n", errors));
            }
        }
        
        await _next(context);
        
    }
}

public static class ValidateUserExtension
{
    public static IApplicationBuilder UseValidateUser(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<ValidateUser>();
    }
}