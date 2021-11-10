using BL.DTOs.BestContactTimeDTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BL.Interfaces
{
	public interface IBestContactTimeService
	{
		Task SaveBestContactTimeAsync(string userName, List<CreateBestContactTimeDTO> models);

		Task<List<BestContactTimeDTO>> GetAllBestTimeByIdAsync(string interviewerId);
	}
}
