using System;
namespace csharp_biblioteca
{
	public class Documento
	{
		public string CodiceIdentificativo { get; set; }
		public string Titolo { get; set; }
		public int Anno { get; set; }
		public string Settore { get; set; }
		public string Scaffale { get; set; }
		public Autore Autore { get; set; }

		public Documento(string codiceIdentificativo, string titolo, int anno, string settore, string scaffale, Autore autore)
		{
			CodiceIdentificativo = codiceIdentificativo;
			Titolo = titolo;
			Anno = anno;
			Settore = settore;
			Scaffale = scaffale;
			Autore = autore;
		}
	}
}

