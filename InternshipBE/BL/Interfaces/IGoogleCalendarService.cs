using System.Threading.Tasks;

namespace BL.Interfaces
{
	public interface IGoogleCalendarService
	{
		public Task GetCalendarEvents();
	}
}
