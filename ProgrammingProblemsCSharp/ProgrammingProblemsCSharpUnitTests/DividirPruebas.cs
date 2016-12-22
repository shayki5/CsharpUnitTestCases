using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProgrammingProblemsCSharp;

namespace ProgrammingProblemsCSharpUnitTests
{
	[TestClass]
	public class DividirPruebas
	{
		[TestMethod]
		public void DivideEnterosPositivos()
		{
			Assert.AreEqual(2, Dividir.Divide(10, 5));
		}

		[TestMethod]
		public void DividirEntre0()
		{
			try
			{
				int result = Dividir.Divide(10, 0);
				Assert.Fail("Exception should have been thrown!");
			}
			catch (ArgumentException e)
			{
				// Success!
				Assert.AreEqual(e.Message, "Los numeros estan repetidos");
			}
			catch (Exception ex)
			{
				Assert.Fail("Unexpected exception " + ex.ToString());
			}
		}
	}
}
