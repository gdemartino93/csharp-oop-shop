using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop
{
    internal class Product
    {
        private string codiceProdotto;
        private string nome;
        private string descrizione;
        private decimal prezzo;
        private int iva;
        //codice prodotto readonly
        public string CodiceProdotto { get
            {
                return codiceProdotto;
            }}

        public string Nome { get; set; }
        public string Descrizione { get; set; }
        public decimal Prezzo { get; set; }
        public int Iva { get; set; }

        public Product()
        {
            codiceProdotto = new Random().Next(1, 1000000).ToString();
        }
        public Product( string nome, string descrizione, decimal prezzo, int iva)
        {
            codiceProdotto = new Random().Next(1, 1000000).ToString();
            Nome = nome;
            Descrizione = descrizione;
            Prezzo = prezzo;
            Iva = iva;
        }
   
        public decimal FullPrice()
        {
            decimal prezzoTotale = Prezzo + (Prezzo * Iva / 100);
            return prezzoTotale;
        }
        public void FullName()
        {
           Console.WriteLine($"{codiceProdotto} - {Nome}");
        }
        public string PadLeft(string codice)
        {
            int lunghezza = codice.Length;
            if ( lunghezza >= 8 )
            {
                return codice;
            }
            else
            {
                return codice.PadLeft(8, '0');
            }
        }
    }

}
