using System;

namespace DAL.Entities
{
	public class BestContactTime
	{
		public int Id { get; set; }

		public DateTime StartTime { get; set; }

		public DateTime EndTime { get; set; }

		public User User { get; set; }
	}
}
