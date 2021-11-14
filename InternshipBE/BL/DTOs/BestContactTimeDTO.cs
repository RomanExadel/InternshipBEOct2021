using System;

namespace BL.DTOs
{
	public class BestContactTimeDTO
	{
		private DateTime startTime;
		private DateTime endTime;

		public int? Id { get; set; }

		public DateTime StartTime
		{
			get
			{
				return startTime;
			}
			set
			{
				startTime = DateTime.Parse(value.ToString("G"));
			}
		}

		public DateTime EndTime
		{
			get
			{
				return endTime;
			}
			set
			{
				endTime = DateTime.Parse(value.ToString("G"));
			}
		}
	}
}
