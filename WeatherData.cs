using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataMungingKata
{
	public class WeatherData
	{
		public bool IsValidRow(string fakeRow)
		{
			string[] rowProperties =
				fakeRow.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

			int output = 0;
			return int.TryParse(rowProperties[0], out output);
		}
	}
}
