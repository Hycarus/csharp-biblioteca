using System;
namespace csharp_biblioteca
{
	public class Libro : Documento
	{
		public int NumeroPagine { get; set; }
		public Libro(string codiceIdentificativo, string titolo, int anno, string settore, string scaffale, Autore autore, int numeroPagine) : base(codiceIdentificativo, titolo, anno, settore, scaffale, autore)
		{
			NumeroPagine = numeroPagine;
		}
	}
}

