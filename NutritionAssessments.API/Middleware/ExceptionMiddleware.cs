using System.Net;
using NutritionAssessments.API.Services;

namespace NutritionAssessments.API.Middleware
{
    public class ExceptionMiddleware(RequestDelegate next, ILoggerService logger)
    {
        public async Task Invoke(HttpContext context)
        {
            try
            {
                await next(context);
            }
            catch (Exception ex)
            {
                logger.LogCritical(ex.Message, ex);
                await HandleExceptionAsync(context, ex);
            }
        }

        private static Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

            var response = new
            {
                message = "Internal server error",
                details = exception.Message
            };

            return context.Response.WriteAsJsonAsync(response);
        }
    }
}