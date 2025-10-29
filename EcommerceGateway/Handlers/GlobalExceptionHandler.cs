using Microsoft.AspNetCore.Diagnostics;
using System.Net;
using System.Text.Json;

namespace EcommerceGateway.Handlers
{
    public class GlobalExceptionHandler : IExceptionHandler
    {
        private readonly ILogger<GlobalExceptionHandler> _logger;
        private readonly IWebHostEnvironment _env;

        public GlobalExceptionHandler(ILogger<GlobalExceptionHandler> logger, IWebHostEnvironment env)
        {
            _logger = logger;
            _env = env;
        }

        public async ValueTask<bool> TryHandleAsync(
            HttpContext httpContext,
            Exception exception,
            CancellationToken cancellationToken)
        {
            // Exception Log
            _logger.LogError(exception, "Unhandled exception at {Path}", httpContext.Request.Path);

            httpContext.Response.ContentType = "application/json";
            httpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

            var message = _env.IsDevelopment() ? exception.Message : "An unexpected error occurred. Please try again later.";
            // ApiResponse<T> format response return 
            var response = ApiResponse<string>.ErrorResponse(message, httpContext.Response.StatusCode);

            var json = JsonSerializer.Serialize(response);
            await httpContext.Response.WriteAsync(json, cancellationToken);

            return true;
        }
    }
}
