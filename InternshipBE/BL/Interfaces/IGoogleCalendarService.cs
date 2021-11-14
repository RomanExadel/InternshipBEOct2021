using BL.DTOs;
using System.Threading.Tasks;

namespace BL.Interfaces
{
	public interface IGoogleCalendarService
	{
		Task CreateEventInCalendarAsync(EventDTO model);
	}
}
