using System.Threading.Tasks;

namespace BL.Interfaces
{
	public interface IGoogleSheetService
	{
		public Task SaveNewCandidatesAsync();
	}
}
