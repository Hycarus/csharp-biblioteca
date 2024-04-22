using System.Security.Cryptography.X509Certificates;

namespace csharp_biblioteca;

class Program : Biblioteca
{
    static void Main(string[] args)
    {

        Biblioteca biblioteca = new Biblioteca();

        Utente utente = new Utente("Pinco", "Pallino", "pincopallino@gmail.com", "prova123", "3407896574");
        biblioteca.AggiungiUtente(utente);

        Utente nuovoUtente = InserimentoDatiUtente();
        biblioteca.AggiungiUtente(nuovoUtente);

        //Console.WriteLine("\nUtenti della biblioteca: ");
        //foreach(Utente user in biblioteca.utenti)
        //{
        //    Console.WriteLine($"\n\nNome: {user.Nome}");
        //    Console.WriteLine($"Cognome: {user.Cognome}");
        //    Console.WriteLine($"Email: {user.Email}");
        //    Console.WriteLine($"Recapito telefonico: {user.RecapitoTelefonico}\n\n");
        //}

        Autore autore = new Autore("Nome autore", "Cognome autore");

        Libro libro = new Libro("257", "Via col vento", 1989, "Romantico", "Scaffale 3A", autore, 254);
        biblioteca.AggiungiDocumento(libro);

        Prestito prestito = new Prestito(nuovoUtente, libro, DateTime.Now, DateTime.Now.AddDays(30));
        biblioteca.AggiungiPrestiti(prestito);

        string scelta = "";
        string tipoRicerca = "";

        while (scelta != "0")
        {
            Console.WriteLine("\nCosa vuoi fare?");
            Console.WriteLine("1. Cercare un documento");
            Console.WriteLine("2. Cercare un prestito");
            Console.WriteLine("0. Terminare il programma");
            scelta = Console.ReadLine();

            if (scelta == "1")
            {
                string internalChoise = "";
                Console.WriteLine("\nInserire il tipo di ricerca: ");
                Console.WriteLine("1. Cercare per titolo");
                Console.WriteLine("2. Cercare per codice");
                string sceltaRicerca = Console.ReadLine();
                if(sceltaRicerca == "1")
                {
                    Console.WriteLine("\nInserire il titolo");
                    string titoloRicerca = Console.ReadLine();
                    List<Documento> doc = biblioteca.CercaDocumento("Titolo", titoloRicerca);
                    foreach (Documento documento in doc)
                    {
                        Console.WriteLine($"\nDocumento trovato!\n\nTitolo: {documento.Titolo}, \nCodice: {documento.CodiceIdentificativo}, \nAnno di pubblicazione: {documento.Anno}, \nSettore: {documento.Settore}, \nScaffale: {documento.Scaffale}, \nAutore: {documento.Autore.Cognome} {documento.Autore.Nome}");
                    }
                }
                else if(sceltaRicerca == "2")
                {
                    Console.WriteLine("\nInserire il codice");
                    string codiceRicerca = Console.ReadLine();
                    List<Documento> doc = biblioteca.CercaDocumento("Codice", codiceRicerca);
                    foreach (Documento documento in doc)
                    {
                        Console.WriteLine($"\nDocumento trovato!\n1\nTitolo: {documento.Titolo}, \nCodice: {documento.CodiceIdentificativo}, \nAnno di pubblicazione: {documento.Anno}, \nSettore: {documento.Settore}, \nScaffale: {documento.Scaffale}, \nAutore: {documento.Autore.Cognome} {documento.Autore.Nome}");
                    }
                }
                
                while (internalChoise != "0")
                {
                    Console.WriteLine("\nInserire il numero relativo all'azione che si vuole eseguire:");
                    Console.WriteLine("1. Richiedere un prestito");
                    Console.WriteLine("0. Tornare alla schermata principale");
                    internalChoise = Console.ReadLine();
                    if (internalChoise == "1")
                    {
                        Prestito pres = new Prestito(nuovoUtente, libro, DateTime.Now, DateTime.Now.AddDays(30));
                        biblioteca.AggiungiPrestiti(prestito);
                        Console.WriteLine("\nPrestito aggiunto correttamente");
                        break;
                    }
                    else if (internalChoise == "0")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\nValore inserito non valido");
                    }
                }
            }
            else if (scelta == "2")
            {
                Console.WriteLine("\nInserire il Cognome: ");
                string CognomeDaCercare = Console.ReadLine();

                List<Prestito> prestiti = biblioteca.CercaPrestito(CognomeDaCercare);
                foreach(Prestito pres in prestiti)
                {
                    Console.WriteLine($"\n{CognomeDaCercare} ha in prestito questo titolo: {pres.Documento.Titolo} fino a {pres.DataFine}");
                }
            }
            else if (scelta == "0")
            { }
            else
            {
                Console.WriteLine("Valore inserito non valido, riprova");
            }
        }
    }

    public static Utente InserimentoDatiUtente()
    {
        Console.WriteLine("Inserisci i tuoi dati:");
        Console.Write("\nCognome: ");
        string? cognome = Console.ReadLine();
        Console.Write("\nNome: ");
        string? nome = Console.ReadLine();
        Console.Write("\nEmail: ");
        string? email = Console.ReadLine();
        Console.Write("\nPassword: ");
        string? password = Console.ReadLine();
        Console.Write("\nTelefono: ");
        string? telefono = Console.ReadLine();

        Utente nuovoUtente = new Utente(cognome, nome, email, password, telefono);
        return nuovoUtente;
    }

    public static string generataCodiceIdentificativo()
    {
        Random rng = new Random();
        return rng.Next(1, 1000).ToString();
    }

    
}

