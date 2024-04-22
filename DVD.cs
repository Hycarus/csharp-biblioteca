using System;
namespace csharp_biblioteca
{
	public class DVD : Documento
	{
		public int Durata { get; set; }

		public DVD(string codiceIdentificativo, string titolo, int anno, string settore, string scaffale, Autore autore, int durata)
            : base(codiceIdentificativo, titolo, anno, settore, scaffale, autore)
		{
			Durata = durata;
		}
	}
}

