namespace BL.DTOs.BestContactTimeDTO
{
	public class BestContactTimeDTO : CreateBestContactTimeDTO
	{
		public int Id { get; set; }

		public UserDTO User { get; set; }
	}
}
