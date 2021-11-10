using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Config.Interfaces
{
	public interface ICalendarEventsConfig
	{
		public string Summary { get; }

		public string Location { get; }

		public string Description { get; }

		public string Recurrence { get; }

		public string TimeZone { get; }
	}
}
