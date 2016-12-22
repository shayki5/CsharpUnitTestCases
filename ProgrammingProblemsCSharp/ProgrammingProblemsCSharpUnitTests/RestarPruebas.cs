using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProgrammingProblemsCSharp;

namespace ProgrammingProblemsCSharpUnitTests
{
	[TestClass]
	public class RestarPruebas
	{
		[TestMethod]
		public void RestarPositivos()
		{
			int Result = Restar.Resta(10,20);
			Assert.AreEqual(Result, -10);
		}

		[TestMethod]
		public void RestarNegativos()
		{
			int Result = Restar.Resta(-10, -20);
			Assert.AreEqual(Result, 10);
		}

		[TestMethod]
		public void RestarNegativosY0()
		{
			int Result = Restar.Resta(-10, 0);
			Assert.AreEqual(Result, -10);
		}
	}
}
