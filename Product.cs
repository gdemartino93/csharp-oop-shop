using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop
{
    internal class Product
    {
        public int CodiceProdotto { get; set; }
        public string Nome { get; set; }
        public string Descrizione { get; set; }
        public decimal Prezzo { get; set; }
        public int Iva { get; set; }

        public Product(int codiceProdotto, string nome, string descrizione, decimal prezzo, int iva)
        {
            codiceProdotto = CodiceProdotto;
            nome = Nome;
            descrizione = Descrizione;
            prezzo = Prezzo;
            Iva = iva;
        }
    }

}
