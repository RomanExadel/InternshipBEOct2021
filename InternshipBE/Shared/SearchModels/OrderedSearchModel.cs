using System;
using System.Linq;
using System.Linq.Expressions;

namespace Shared.SearchModels
{
	public abstract class OrderedSearchModel<TEntity> : OrderedSearchModel<TEntity, TEntity>
	{
		protected virtual IQueryable<TEntity> BuildView(IQueryable<TEntity> query)
		{
			return query;
		}
	}

	public abstract class OrderedSearchModel<TEntity, TView> : SearchModel<TEntity, TView>
	{
		public bool Reverse { get; set; }

		public string Predicate { get; set; }

		protected IQueryable<TView> Order<TProperty>(IQueryable<TView> query, Expression<Func<TView, TProperty>> expression)
		{
			return Reverse ? query.OrderByDescending(expression) : query.OrderBy(expression);
		}
	}
}
