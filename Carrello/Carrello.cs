using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrello
{
    public class Carrello
    {
        private string _id;
        private Prodotto[] prodotto;
        private int counter;

        public Carrello(string id, int nr)
        {
            Id = id;
            prodotto = new Prodotto[nr];
        }

        public string Id
        {
            get 
            { 
                return _id; 
            }
            set
            { 
                _id = value; 
            }
        }

        public void Aggiungi(Prodotto x)
        {
            x.Id = prodotto[counter].Id;
            counter++;
        }

        public void Rimuovi(Prodotto x)
        {
            x.Id = prodotto[counter].Id;
            counter--;
        }

        public void Svuota()
        {
            counter = 0;
        }

        public int getProdotti()
        {
            return counter;
        }
    }
}
