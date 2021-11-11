using System.Linq;

namespace Shared.SearchModels
{
	public interface IFilterable<TEntity>
	{
		IQueryable<TEntity> Filter(IQueryable<TEntity> query);
	}

	public abstract class SearchModel<TEntity> : SearchModel<TEntity, TEntity>
	{
		protected virtual IQueryable<TEntity> BuildView(IQueryable<TEntity> query)
		{
			return query;
		}
	}

	public abstract class SearchModel<TEntity, TView> : IFilterable<TView>
	{
		public int Skip { get; set; } = 0;

		public virtual int Take { get; set; } = 20;

		protected abstract IQueryable<TView> Ordering(IQueryable<TView> query);

		public virtual IQueryable<TView> Filter(IQueryable<TView> view)
		{
			return view;
		}
	}
}
