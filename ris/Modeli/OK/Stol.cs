using System;
using System.Collections.Generic;
using System.Text;

namespace ris.Modeli.OK
{
    public class Stol
    {
        public int Id { get; set; }
        public string Opis { get; set; }
        public int Mjesta { get; set; }
        public enum Statusi
        {
            slobodan,
            zauzet,
            rezerviran
        }
        public Statusi Status { get; set; }
        public override string ToString()
        {
            return Opis;
        }
    }
}
