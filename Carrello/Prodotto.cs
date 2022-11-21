using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrello
{
    public class Prodotto
    {
        private string _nome;
        private string _produttore;
        private string _id;
        private float _prezzo;

        public Prodotto(string nome, string produttore, string id, float prezzo)
        {
            Nome = nome;
            Produttore = produttore;
            Id = id;
            Prezzo = prezzo;
        }

        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                _nome = value;
            }
        }

        public string Produttore
        {
            get
            {
                return _produttore;
            }
            set
            {
                _produttore = value;
            }
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

        public float Prezzo
        {
            get
            {
                return _prezzo;
            }
            set
            {
                _prezzo = value;
            }
        }

        public void setPrezzo(float delta)
        {
            this._prezzo = delta;
        }
    }
}
