using System;
using System.Collections.Generic;
using System.Text;

namespace ris.Modeli.OK
{
    public class Kategorija
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public  string Opis { get; set; }
        public override string ToString()
        {
            return Naziv;
        }
    }
}
