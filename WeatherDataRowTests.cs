using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace DataMungingKata
{
	[TestFixture]
	public class WeatherDataRowTests
	{
		[Test]
		public void WeatherDataRowHasDayMinimumTemperatureMaximumTemperatureTest()
		{
			WeatherDataRow wr = new WeatherDataRow();

			Assert.That(wr.Day, Is.GreaterThanOrEqualTo(0));
			Assert.That(wr.MinimumTemperature, Is.GreaterThanOrEqualTo(0));
			Assert.That(wr.MaximumTemperature, Is.GreaterThanOrEqualTo(0));
		}

		[Test]
		public void CanGetTemperatureRangeTest()
		{
			WeatherDataRow wr = new WeatherDataRow();

			wr.MinimumTemperature = 59;
			wr.MaximumTemperature = 88;

			int temperatureRange = wr.DetermineTemperatureRange();

			Assert.That(temperatureRange, Is.EqualTo(29));
		}
	}
}
