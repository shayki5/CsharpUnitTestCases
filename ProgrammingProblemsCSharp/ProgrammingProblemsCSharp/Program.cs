using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingProblemsCSharp
{
	//Tarea
	// 1. Invertir arreglo de caracteres
	// Ejemplo:
	// Input: "abc"
	// Output (en la misma variable, no como return) : "cba"

	// 2. En un arreglo de enteros, hay todos los numeros de 1 a N (una vez cada uno) menos uno de ellos
	// Input: El arreglo de enteros
	// Output: El numero que falta
	// Bonus: Casos "malos" como numeros repetidos, numeros fuera de rango, etc

	class Program
	{
		static void Main(string[] args)
		{
			int a = 10;
			int b = 0;
			try
			{
				int resunt = Divide(a, b);
				Console.WriteLine(resunt);
			}
			catch(Exception ex)
			{
				Console.WriteLine("Error! " + ex.ToString());
			}
			Console.ReadKey();
			//	Console.WriteLine("Sumar!");
			//	int x = 10;
			//	int y = 20;
			//	int result = Restar.Resta(10, 20);
			//	Console.WriteLine(result);
			//	Console.ReadKey();
			//
		}

		public static int Divide(int x, int y)
		{
			return x / y;
		}
	}
}
