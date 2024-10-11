using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EISG.ManipuladorCadenasTexto
{
	public class StringManipulator
	{
		// Método que invierte la cadena de texto
		public string ReverseString(string input)
		{
			// Convertir la cadena a un array de caracteres, invertir el array y devolverlo como string
			char[] charArray = input.ToCharArray();
			Array.Reverse(charArray);
			return new string(charArray);
		}

		// Método que elimina todos los espacios en blanco de la cadena
		public string RemoveSpaces(string input)
		{
			// Eliminar todos los espacios de la cadena usando Replace
			return input.Replace(" ", "");
		}
	}
}
