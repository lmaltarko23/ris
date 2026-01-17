using System;
using System.Collections.Generic;
using System.Text;

namespace ris.Modeli
{
    internal class Artikl
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public float Cijena { get; set; }
        public Kategorija Kategorija { get; set; }
        public bool Dostupan { get; set;}
    }
}
