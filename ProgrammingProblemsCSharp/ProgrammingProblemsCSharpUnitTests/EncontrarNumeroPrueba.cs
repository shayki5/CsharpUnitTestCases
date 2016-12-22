using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProgrammingProblemsCSharp;

namespace ProgrammingProblemsCSharpUnitTests
{
	[TestClass]
	public class EncontrarNumeroPrueba
	{
		[TestMethod]
		public void PruebaFaltaNumeroChico()
		{
			int[] arr = { 2, 3, 4, 6, 5, 7, 9, 8, 10, 11, 12, 14, 13 };
			int size = 14;
			Assert.AreEqual(1, EncontrarNumero.EncontarNumeroQueFlata(arr, size));
		}
		[TestMethod]
		public void PruebaFaltaNumeroGrande()
		{
			int[] arr = { 1, 2, 3, 4, 6, 5, 7, 9, 8, 10, 11, 14, 13 };
			int size = 14;
			Assert.AreEqual(12, EncontrarNumero.EncontarNumeroQueFlata(arr, size));
		}
		[TestMethod]
		public void HayNegativosEnArreglo()
		{
			int[] arr = { 2, 3, 4, 6, 5, 7, 9, 8, -10, 11, 12, 14, 13 };
			int size = 14;
			try
			{
				EncontrarNumero.EncontarNumeroQueFlata(arr, size);
				Assert.Fail("An exception should have been thrown");
			}
			catch(ArgumentOutOfRangeException)
			{
				//success
			}
		}
		[TestMethod]
		public void Hay0EnArreglo()
		{
			int[] arr = { 2, 3, 4, 6, 5, 7, 0, 8, 10, 11, 12, 14, 13 };
			int size = 14;
			try
			{
				EncontrarNumero.EncontarNumeroQueFlata(arr, size);
				Assert.Fail("An exception should have been thrown");
			}
			catch (ArgumentOutOfRangeException)
			{
				//success
			}
		}
	}
}
