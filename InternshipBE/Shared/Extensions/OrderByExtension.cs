using System;
using System.Linq;
using System.Linq.Expressions;
namespace Shared.Extensions
{
	public static class OrderByExtension
	{
		private const string DefaultSortParametr = "StatusType";

		public static IQueryable<T> OrderByPropertyName<T>(this IQueryable<T> query, string SortBy, bool IsDesc)
		{
			var propertyInfos = typeof(T).GetProperties().Select(x => x.Name.ToUpper()).ToList();

			var parameter = Expression.Parameter(typeof(T), "p");
			var property = propertyInfos.Contains(SortBy.ToUpper()) ? Expression.Property(parameter, SortBy) : Expression.Property(parameter, DefaultSortParametr);
			var expression = Expression.Lambda(property, parameter);
			string method = IsDesc ? "OrderBy" : "OrderByDescending";
			Type[] types = new Type[] { query.ElementType, expression.Body.Type };

			var result = Expression.Call(typeof(Queryable), method, types, query.Expression, expression);

			return query.Provider.CreateQuery<T>(result);
		}
	}
}
