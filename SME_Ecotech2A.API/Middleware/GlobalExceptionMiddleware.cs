using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using SME_Ecotech2A.API.Common.Response;
using System;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;

namespace SME_Ecotech2A.Api.Middleware
{
    public class GlobalExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<GlobalExceptionMiddleware> _logger;

        public GlobalExceptionMiddleware(RequestDelegate next, ILogger<GlobalExceptionMiddleware> logger)
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
                _logger.LogError(ex, "Unhandled exception occurred while processing request");
                await HandleExceptionAsync(context, ex);
            }
        }

        private static Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            var code = exception switch
            {
                // NotFoundException => HttpStatusCode.NotFound, 
                // BadRequestException => HttpStatusCode.BadRequest,

                _ => HttpStatusCode.InternalServerError
            };
            var payload  = ApiResponse<object>.Fail(exception.Message, (int)code);

            var result = JsonSerializer.Serialize(payload);
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)code;
            return context.Response.WriteAsync(result);
        }
       
    }
}
