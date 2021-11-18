using Microsoft.AspNetCore.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Shared.Middleware
{
	public class CultureMiddleware
	{
        private readonly RequestDelegate _next;

        public CultureMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var acceptedLanguages = context.Request.Headers["Accept-Language"].ToString();

            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(acceptedLanguages.Split(',')[0]);
            Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture;

            await _next.Invoke(context);
        }
    }
}
