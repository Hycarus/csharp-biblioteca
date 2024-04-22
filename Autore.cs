using System;
namespace csharp_biblioteca
{
	public class Autore
	{
		public string Nome { get; set; }
		public string Cognome { get; set; }
		public Autore(string nome, string cognome)
		{
			Nome = nome;
			Cognome = cognome;
		}
	}
}

