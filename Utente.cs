using System;
namespace csharp_biblioteca
{
	public class Utente
	{
        public string Cognome { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string RecapitoTelefonico { get; set; }

        public Utente(string cognome, string nome, string email, string password, string recapitoTelefonico)
        {
            Cognome = cognome;
            Nome = nome;
            Email = email;
            Password = password;
            RecapitoTelefonico = recapitoTelefonico;
        }
    }
}

