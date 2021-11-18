using Microsoft.AspNetCore.Builder;
using Shared.Middleware;

namespace Shared.Extensions
{
	public static class CultureMiddlewareExtension
	{
		public static void UseCultureMiddleware(this IApplicationBuilder app)
		{
			app.UseMiddleware<CultureMiddleware>();
		}
	}
}
