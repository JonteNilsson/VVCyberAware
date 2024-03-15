
namespace VVCyberAware.Middleware;

public class LoggingMiddleware : IMiddleware
{
    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        Console.WriteLine($"Request path: {context.Request.Path}");
        await next(context);
    }
}
