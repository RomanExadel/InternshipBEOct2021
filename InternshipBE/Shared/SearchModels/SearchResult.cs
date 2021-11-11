using System.Linq;

namespace Shared.SearchModels
{
	public class SearchResult<TEntity>
	{
		public IQueryable<TEntity> Body { get; set; }
		public int FullCount { get; set; }
		public int Count { get; set; }
	}
}
