using System.Text;

namespace VVCyberAware.API.Middlewares
{
    public class ApiCallLogging
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ApiCallLogging> _logger;

        public ApiCallLogging(RequestDelegate next, ILogger<ApiCallLogging> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext context)
        {
            string requestMethod = context.Request.Method;
            string requestPath = context.Request.Path;
            string requestBody = await FormatRequest(context.Request);

            _logger.LogInformation("Incomming request: {RequestMethod} {RequestPath}", requestMethod, requestPath);
            _logger.LogInformation("Request body: {RequestBody}", requestBody);

            Console.WriteLine($"Incoming request: {requestMethod} {requestPath}");
            Console.WriteLine($"Request body: {requestBody}");

            await _next(context);
        }

        private async Task<string> FormatRequest(HttpRequest request)
        {
            string bodyText = "";

            if (request.ContentLength != null && request.ContentLength > 0)
            {
                using (StreamReader reader = new StreamReader(request.Body, Encoding.UTF8, true, 1024, true))
                {
                    bodyText = await reader.ReadToEndAsync();

                    request.Body.Position = 0;
                }
            }

            return bodyText;
        }
    }

    public static class ApiCallLoggingExtensions
    {
        public static IApplicationBuilder UseApiRequestLoggingMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ApiCallLogging>();
        }
    }
}

