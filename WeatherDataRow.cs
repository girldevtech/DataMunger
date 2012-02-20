using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataMungingKata
{
	public class WeatherDataRow
	{

		public int Day { get; set; }
		public int MinimumTemperature { get; set; }
		public int MaximumTemperature { get; set; }

		public int DetermineTemperatureRange()
		{
			return MaximumTemperature - MinimumTemperature;
		}
	}
}
