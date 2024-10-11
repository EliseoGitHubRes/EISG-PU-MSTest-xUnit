using Microsoft.VisualStudio.TestTools.UnitTesting;
using EISG.Temperatura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EISG.Temperatura.Tests
{
	[TestClass()]
	public class TemperatureConverterTests
	{
		[TestMethod()]
		public void CelsiusToFahrenheitTest()
		{
			// Arrange
			TemperatureConverter converter = new TemperatureConverter();
			double celsius = 0; // 0°C debería ser 32°F

			// Act
			double result = converter.CelsiusToFahrenheit(celsius);

			// Assert
			Assert.AreEqual(32, result, 0.001, "0°C debería ser 32°F");
		}

		[TestMethod()]
		public void FahrenheitToCelsiusTest()
		{
			// Arrange
			TemperatureConverter converter = new TemperatureConverter();
			double fahrenheit = 32; // 32°F debería ser 0°C

			// Act
			double result = converter.FahrenheitToCelsius(fahrenheit);

			// Assert
			Assert.AreEqual(0, result, 0.001, "32°F debería ser 0°C");
		}
	}
}