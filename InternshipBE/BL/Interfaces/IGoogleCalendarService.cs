using BL.DTOs.BestContactTimeDTO;
using System.Threading.Tasks;

namespace BL.Interfaces
{
	public interface IGoogleCalendarService
	{
		Task CreateEventInCalendarAsync(BestContactTimeEventDTO model);
	}
}
