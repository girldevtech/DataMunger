using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace DataMungingKata
{
	[TestFixture]
	public class WeatherDataRowsTests
	{
		[Test]
		public void CanInstantiateWeatherDataRowsTest()
		{
			WeatherDataRows rows = new WeatherDataRows();

			Assert.That(rows, Is.Not.Null);
		}

		[Test]
		public void CanDetermineMinimumTemperatureRangeTest()
		{
			WeatherDataRows rows = new WeatherDataRows();
			WeatherDataRow one = new WeatherDataRow
			{
				MinimumTemperature = 59,
				MaximumTemperature = 88
			};
			WeatherDataRow two = new WeatherDataRow
			{
				MinimumTemperature = 63,
				MaximumTemperature = 79
			};
			WeatherDataRow three = new WeatherDataRow
			{
				MinimumTemperature = 55,
				MaximumTemperature = 77
			};
			rows.Add(one);
			rows.Add(two);
			rows.Add(three);

			int minimumRange = rows.GetMinimumTemperatureRange();

			Assert.That(minimumRange, Is.EqualTo(16));
		}
	}
}
