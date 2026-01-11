using System;
using System.Collections.Generic;
using System.Text;

namespace ris.Modeli
{
    internal class Stol
    {
        public int Id { get; set; }
        public string Opis { get; set; }
        public int Mjesta { get; set; }
        public enum Statusi
        {
            slobodan,   zauzet,     rezerviran
        }
        public Statusi Status { get; set; }
    }
}
