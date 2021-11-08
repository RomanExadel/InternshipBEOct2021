using BL.DTOs;
using System.Threading.Tasks;

namespace BL.Interfaces
{
	public interface IGoogleCalendarService
	{
		Task CreateEventInCalendarAsync(string interviewerID, BestContactTimeDTO model);
	}
}
