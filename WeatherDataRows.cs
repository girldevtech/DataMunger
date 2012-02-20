using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataMungingKata
{
	public class WeatherDataRows : List<WeatherDataRow>
	{
		public int GetMinimumTemperatureRange()
		{
			int minimumRange = this[0].DetermineTemperatureRange();
			for(int i = 0; i<this.Count; i++)
			{
				int range = this[i].DetermineTemperatureRange();
				if (range < minimumRange)
				{
					minimumRange = range;
				}
			}

			return minimumRange;
		}
	}
}
