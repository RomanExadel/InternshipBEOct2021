using Google.Apis.Calendar.v3.Data;
using System.Threading.Tasks;

namespace BL.Interfaces
{
	public interface IGoogleCalendarService
	{
		public Task<Events> GetCalendarEvents();
	}
}
