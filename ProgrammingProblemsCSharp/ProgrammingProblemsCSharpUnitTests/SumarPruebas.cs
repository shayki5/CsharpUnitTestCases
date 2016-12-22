using Microsoft.VisualStudio.TestTools.UnitTesting;

using ProgrammingProblemsCSharp;

namespace ProgrammingProblemsCSharpUnitTests
{
	[TestClass]
	public class SumarPruebas
	{

		[TestMethod]
		public void SumaNumerosNegativos()
		{
			int x = 10;
			int y = 20;
			int jorge = Sumar.Suma(x, y);
			Assert.AreEqual(jorge, 30);
		}

		[TestMethod]
		public void SumaNumeros0()
		{
			int x = 10;
			int y = 20;
			int result = Sumar.Suma(x, y);
			Assert.AreEqual(result, 30);
		}

		[TestMethod]
		public void SumaNumerosPositivosYNegativos()
		{
			int x = 10;
			int y = 20;
			int result = Sumar.Suma(x, y);
			Assert.AreEqual(result, 30);
		}
	}
}
