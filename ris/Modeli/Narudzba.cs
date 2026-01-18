using ris.Modeli.OK;
using System;
using System.Collections.Generic;
using System.Text;

namespace ris.Modeli
{
    public class Narudzba
    {
        public int Id { get; set; }
        public Djelatnik Zaprimio { get; set; }
        public DateTime Zaprimljena { get; set; }
        public DateTime Ispunjena { get; set; }
        public enum StatusEnum { Aktivna, U_pripremi, Gotova, Naplaćena};
        public StatusEnum Status { get; set; }
        public Stol Stol { get; set; }

        internal static StatusEnum Parse(string? v)
        {
            switch (v) { 
                case "aktivna":
                    return StatusEnum.Aktivna;
                    break;
                case "u_pripremi":
                    return StatusEnum.U_pripremi;
                    break;
                case "gotova":
                    return StatusEnum.Gotova;
                    break;
                case "naplacena":
                    return StatusEnum.Naplaćena;
                    break;
            }
            return StatusEnum.Aktivna;
        }
    }
}
