using System.Collections.Generic;

namespace Shared.SearchModels
{
	public class SearchResultModel<TModel>
	{
		public SearchResultModel()
		{
			List = new List<TModel>();
		}

		public List<TModel> List { get; set; }
		public int Count { get; set; }
	}
}
