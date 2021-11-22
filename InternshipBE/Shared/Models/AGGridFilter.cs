namespace Shared.Models
{
	public class AGGridFilter
	{
		public int Skip { get; set; }

		public int Take { get; set; }

		public string SearchText { get; set; }

		public string SortBy { get; set; }

		public bool IsDesc { get; set; }
	}
}
