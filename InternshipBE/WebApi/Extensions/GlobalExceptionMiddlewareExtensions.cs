using Microsoft.AspNetCore.Builder;
using Shared.Middleware;

namespace WebApi.Extensions
{
    public static class GlobalExceptionMiddlewareExtensions
    {
        public static void UseGlobalExceptionMiddleware(this IApplicationBuilder app)
        {
            app.UseExceptionHandler(appError =>
            {
                appError.UseMiddleware<ExceptionMiddleware>();
            });
        }
    }
}
