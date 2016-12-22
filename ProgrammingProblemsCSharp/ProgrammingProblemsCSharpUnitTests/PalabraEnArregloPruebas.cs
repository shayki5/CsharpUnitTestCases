using Microsoft.VisualStudio.TestTools.UnitTesting;

using ProgrammingProblemsCSharp;

namespace ProgrammingProblemsCSharpUnitTests
{
	[TestClass]
	public class PalabraEnArregloPruebas
	{
		[TestMethod]
		public void PalabraDentro()
		{
			string enunciado = "Hola, mi nombre es jorge.";
			string palabra = "jorge";

			bool result = DeteectorDePalabras.ContienePalabra(enunciado, palabra);
			Assert.IsTrue(result);
		}

		[TestMethod]
		public void PalabraCasiDentro()
		{
			string enunciado = "jorg, mi nombre es jorg.";
			string palabra = "jorge";

			bool result = DeteectorDePalabras.ContienePalabra(enunciado, palabra);
			Assert.IsFalse(result);
		}

		[TestMethod]
		public void PalabraNoeDentro()
		{
			string enunciado = "Hola, mi nombre es tono.";
			string palabra = "jorge";

			bool result = DeteectorDePalabras.ContienePalabra(enunciado, palabra);
			Assert.IsFalse(result);
		}

		[TestMethod]
		public void EnunciadoVacio()
		{
			string enunciado = "";
			string palabra = "jorge";

			bool result = DeteectorDePalabras.ContienePalabra(enunciado, palabra);
			Assert.IsFalse(result);
		}

		[TestMethod]
		public void PalabraVacia()
		{
			string enunciado = "as;ldka;slkd;alskd;alsk";
			string palabra = "";

			bool result = DeteectorDePalabras.ContienePalabra(enunciado, palabra);
			Assert.IsFalse(result);
		}
	}
}
