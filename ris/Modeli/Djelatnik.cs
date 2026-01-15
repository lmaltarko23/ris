using System;
using System.Collections.Generic;
using System.Text;

namespace ris.Modeli
{
    public class Djelatnik
    {
        public int Id { get; set; }
        public long Oib { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public enumUloga Uloga { get; set; }
        public bool Aktivan { get; set; }
        public override string ToString()
        {
            return Ime + " " + Prezime + " (#" + Id + ")";
        }

        public enum enumUloga {voditelj, kuhar, konobar};
    }
}
