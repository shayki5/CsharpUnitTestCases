using System;

namespace ProgrammingProblemsCSharp
{
	public static class Dividir
	{
		public static int Divide(int x, int y)
		{
			if (y == 0)
			{
				throw new ArgumentException("Los numeros estan repetidos");
			}

			return x / y;
		}
	}
}
