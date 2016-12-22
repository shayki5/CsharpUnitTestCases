namespace ProgrammingProblemsCSharp
{
	public class DeteectorDePalabras
	{
		public static bool ContienePalabra(string enunciado, string palabra)
		{
			if (palabra == "" || enunciado == "")
			{
				return false;
			}

			for(int inicial = 0; inicial < enunciado.Length - palabra.Length; inicial++)
			{
				int indexPalabra;
				for(indexPalabra = 0; indexPalabra < palabra.Length; indexPalabra++)
				{
					char caracterEnEnunciado = enunciado[inicial + indexPalabra];
					char caracterPalabra = palabra[indexPalabra];

					if (caracterEnEnunciado != caracterPalabra)
					{
						break;
					}
				}

				if (indexPalabra == palabra.Length)
				{
					return true;
				}
			}

			return false;
		}
	}
}
