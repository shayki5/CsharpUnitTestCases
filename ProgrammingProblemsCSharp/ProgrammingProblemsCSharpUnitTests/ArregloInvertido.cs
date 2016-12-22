using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProgrammingProblemsCSharp;

namespace ProgrammingProblemsCSharpUnitTests
{
	[TestClass]
	public class ArregloInvertido
	{
		[TestMethod]
		public void PrimerCaracter()
		{
			int size = 3;
			char[] arr = { 'a', 'b', 'c' };
			InvertirArreglos.InverirCaracteres(arr,size);
			Assert.AreEqual('c', arr[0]);
		}
		[TestMethod]
		public void CaracterEnmedio()
		{
			int size = 3;
			char[] arr = { 'a', 'b', 'c' };
			InvertirArreglos.InverirCaracteres(arr, size);
			Assert.AreEqual('b', arr[1]);
		}
		[TestMethod]
		public void UltimoCaracter()
		{
			int size = 3;
			char[] arr = { 'a', 'b', 'c' };
			InvertirArreglos.InverirCaracteres(arr, size);
			Assert.AreEqual('a', arr[2]);
		}

		[TestMethod]
		public void SwapTest()
		{
			char x = 'a';
			char y = 'b';
			InvertirArreglos.Swap(ref x, ref y);
			Assert.AreEqual(x, 'b');
			Assert.AreEqual(y, 'a');
		}
	}
}
