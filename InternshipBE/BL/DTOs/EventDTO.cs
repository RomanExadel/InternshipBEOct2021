using System;

namespace BL.DTOs
{
	public class EventDTO
	{
		private DateTime startTime;
		private DateTime endTime;

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

		public string InterviewerEmail { get; set; }
	}
}
