using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace DataMungingKata
{
	[TestFixture]
	public class WeatherDataTests
	{
		[Test]
		public void ValidWeatherDataRowBeginsWithIntegerTest()
		{
			string fakeRow = "1 88";
			WeatherData data = new WeatherData();

			bool isValid = data.IsValidRow(fakeRow);

			Assert.That(isValid, Is.True);
		}

	}
}
