using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingProblemsCSharp
{
	public static class EncontrarNumero
	{
		public static int EncontarNumeroQueFlata(int[] arr, int size)
		{
			
			int Result = SumatoriaReal(size) - SumatoriaArreglo(arr, size);
			return Result;
		}
		public static int SumatoriaReal(int size)
		{
			int suma = 0;
			for(int i = 1; i <= size; i++ )
			{
				suma += i;
			}
			return suma;
		}
		public static int SumatoriaArreglo(int[] arr, int size)
		{
			int sumaArreglo = 0;
			for (int i = 0; i < size - 1; i++)
			{
				if(arr[i] <= 0)
				{
					throw new ArgumentOutOfRangeException();
				}
				sumaArreglo += arr[i];
			}
			return sumaArreglo;
		}

	}


}
