using System.Net;
using System.Text.Json;
using ZenOS.MB;
using ZenOS.Util;

namespace ZenOS.API.Middleware
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ExceptionMiddleware> _logger;

        public ExceptionMiddleware(RequestDelegate next, ILogger<ExceptionMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);

                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                context.Response.ContentType = "application/json";

                var result = new APIResults<string>
                {
                    IsSuccess = false,
                    Message = Messages.InternalServerError
                };

                await context.Response.WriteAsync(JsonSerializer.Serialize(result));
            }
        }
    }
}