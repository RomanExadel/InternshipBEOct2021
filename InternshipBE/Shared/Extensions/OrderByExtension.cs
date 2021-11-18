using System;
using System.Linq;
using System.Linq.Expressions;
namespace Shared.Extensions
{
	public static class OrderByExtension
	{
		public static IQueryable<T> OrderByPropertyName<T>(this IQueryable<T> query, string SortBy, bool IsDesc)
		{
			var parameter = Expression.Parameter(typeof(T), "p");
			var property = Expression.Property(parameter, SortBy);
			var expression = Expression.Lambda(property, parameter);
			string method = IsDesc ? "OrderBy" : "OrderByDescending";
			Type[] types = new Type[] { query.ElementType, expression.Body.Type };

			var result = Expression.Call(typeof(Queryable), method, types, query.Expression, expression);

			return query.Provider.CreateQuery<T>(result);
		}
	}
}
