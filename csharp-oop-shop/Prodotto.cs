using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop
{
    internal class Prodotto
    {
        //attributi
        private string nome;    
        private int codice;
        private string descrizione;
        private double prezzo;
        private int iva;

        //costruttore con descrizione
        public Prodotto(string nome,string descrizione, int prezzo, int ivaApplicabile)
        {
            this.nome = nome;
            this.prezzo = prezzo; 
            this.descrizione = descrizione;
            iva = ivaApplicabile;
            
            Random rnd = new Random();

            codice = rnd.Next(1, 100000000);
        }
        //costruttore senza descizione
        public Prodotto(string nome, int prezzo, int ivaApplicabile)
        {
            this.nome = nome;
            this.prezzo = prezzo;
            iva = ivaApplicabile;

            Random rnd = new Random();

            codice = rnd.Next(1, 100000000);
        }

        //Lettura attributi
        
        
    }
}
