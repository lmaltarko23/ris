using System;
using System.Collections.Generic;
using System.Text;

namespace ris.Modeli
{
    internal class Narudzba
    {
        public int Id { get; set; }
        public Djelatnik Zaprimio { get; set; }
        public DateTime Zaprimljena { get; set; }
        public DateTime Ispunjena { get; set; }
        public enum StatusEnum { Aktivna, U_pripremi, Gotova, Naplaćena};
        public StatusEnum Status { get; set; }
        public Stol Stol { get; set; }
    }
}
