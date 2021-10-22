using Microsoft.AspNetCore.Builder;
using Shared.Middleware;

namespace Shared.Extensions
{
    public static class GlobalExceptionMiddlewareExtensions
    {
        public static void UseGlobalExceptionMiddleware(this IApplicationBuilder app)
        {
            app.UseMiddleware<ExceptionMiddleware>();
        }
    }
}
