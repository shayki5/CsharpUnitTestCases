using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingProblemsCSharp
{
	public static class InvertirArreglos
	{
		public static void InverirCaracteres(char[] arr, int Size)
		{
			for(int i = 0; i < Size/2; i++)
			{
				char z = arr[i];
				arr[i] = arr[(Size -2) - i + 1];
				arr[(Size -2) - i + 1] = z;
			}
		}

		public static void Swap(ref char x, ref char y)
		{
			char z = x;
			x = y;
			y = z;
		}
	}
}
