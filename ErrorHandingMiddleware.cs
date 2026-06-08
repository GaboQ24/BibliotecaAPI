using System.Net;
using System.Text.Json;

namespace Proyecto_Final.Middleware
{
    public class ErrorHandlingMiddleware
    {
        private readonly RequestDelegate _next;

        public ErrorHandlingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context); // continúa con la petición
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }

        private static Task HandleExceptionAsync(HttpContext context, Exception ex)
        {
            var code = HttpStatusCode.InternalServerError; // 500 por defecto

            // Puedes personalizar según el tipo de excepción
            if (ex is ArgumentException) code = HttpStatusCode.BadRequest;
            if (ex is UnauthorizedAccessException) code = HttpStatusCode.Unauthorized;

            var result = JsonSerializer.Serialize(new
            {
                error = ex.Message,
                statusCode = (int)code
            });

            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)code;

            return context.Response.WriteAsync(result);
        }
    }
}
