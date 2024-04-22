using System;
namespace csharp_biblioteca
{
	public class Prestito
	{
		public Utente Utente { get; set; }
		public Documento Documento { get; set; }
		public DateTime DataInizio { get; set; }
		public DateTime DataFine { get; set; }
		public Prestito(Utente utente, Documento documento, DateTime dataInizio, DateTime dataFine)
		{
			Utente = utente;
			Documento = documento;
			DataInizio = dataInizio;
			DataFine = dataFine;
		}
	}
}

