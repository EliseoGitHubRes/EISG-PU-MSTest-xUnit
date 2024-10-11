using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EISG.Temperatura
{
	public class TemperatureConverter
	{
		public double CelsiusToFahrenheit(double celsius)
		{
			// Fórmula para convertir de Celsius a Fahrenheit: (Celsius * 9/5) + 32
			return (celsius * 9 / 5) + 32;
		}

		public double FahrenheitToCelsius(double fahrenheit)
		{
			// Fórmula para convertir de Fahrenheit a Celsius: (Fahrenheit - 32) * 5/9
			return (fahrenheit - 32) * 5 / 9;
		}
	}
}
