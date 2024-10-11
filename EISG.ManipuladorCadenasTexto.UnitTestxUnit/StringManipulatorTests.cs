using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EISG.ManipuladorCadenasTexto.UnitTestxUnit
{
	public class StringManipulatorTests
	{
		[Fact]
		public void ReverseString_ShouldReturnReversedString_Eliseo()
		{
			// Arrange
			StringManipulator stringManipulator = new StringManipulator();
			string input = "Eliseo";

			// Act
			string result = stringManipulator.ReverseString(input);

			// Assert
			Assert.Equal("oesilE", result);
		}

		[Fact]
		public void RemoveSpaces_ShouldReturnStringWithoutSpaces_HolaEliseo()
		{
			// Arrange
			StringManipulator stringManipulator = new StringManipulator();
			string input = "Hola Eliseo";

			// Act
			string result = stringManipulator.RemoveSpaces(input);

			// Assert
			Assert.Equal("HolaEliseo", result);
		}
	}
}
