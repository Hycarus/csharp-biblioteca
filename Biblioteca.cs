using System;
using System.Linq.Expressions;

namespace csharp_biblioteca
{
	public class Biblioteca
	{
        public List<Documento> documenti;
        public List<Utente> utenti;
        public List<Prestito> prestiti;
        
        public Biblioteca()
		{
            documenti = new List<Documento>();
            utenti = new List<Utente>();
            prestiti = new List<Prestito>();
		}

        public void AggiungiDocumento(Documento documento)
        {
            documenti.Add(documento);
        }

        public void AggiungiUtente(Utente utente)
        {
            utenti.Add(utente);
        }

        public void AggiungiPrestiti(Prestito prestito)
        {
            prestiti.Add(prestito);
        }

        public List<Documento> CercaDocumento(string tipoRicerca, string valoreRicerca)
        {
            List<Documento> risultati = new List<Documento>();
            foreach(Documento documento in documenti)
            {
                if(tipoRicerca.Equals("codice", StringComparison.OrdinalIgnoreCase))
                {
                    if (documento.CodiceIdentificativo.Equals(valoreRicerca, StringComparison.OrdinalIgnoreCase))
                    {
                        risultati.Add(documento);
                        return risultati;
                    }
                }else if(tipoRicerca.Equals("titolo", StringComparison.OrdinalIgnoreCase)){
                    if (documento.Titolo.Equals(valoreRicerca, StringComparison.OrdinalIgnoreCase))
                    {
                        risultati.Add(documento);
                    }
                }
            }
            if(tipoRicerca.Equals("codice", StringComparison.OrdinalIgnoreCase) && risultati.Count == 0)
            {
                Console.WriteLine("Non abbiamo trovato nessuna corrispondenza per il codice specificato");
            }
            return risultati;
        }

        public List<Prestito> CercaPrestito(string cognome, string nome)
        {
            HashSet<Prestito> risultati = new HashSet<Prestito>();
            foreach(Prestito prestito in prestiti)
            {
                if (prestito.Utente.Cognome.Equals(cognome, StringComparison.OrdinalIgnoreCase) && prestito.Utente.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase))
                    risultati.Add(prestito);
            }
            if (risultati.Count == 0)
            {
                Console.WriteLine("Non ci sono prestiti a questo nome");
            }
            return risultati.ToList();
        }
    }
}

