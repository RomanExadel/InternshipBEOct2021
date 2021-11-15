using System;

namespace BL.DTOs
{
	public class EventDTO
	{
		private DateTime _startTime;
		private DateTime _endTime;

		public DateTime StartTime
		{
			get => _startTime;

			set => _startTime = DateTime.Parse(value.ToString("G"));
		}

		public DateTime EndTime
		{
			get => _endTime;

			set => _endTime = DateTime.Parse(value.ToString("G"));
		}

		public string InterviewerEmail { get; set; }
	}
}
