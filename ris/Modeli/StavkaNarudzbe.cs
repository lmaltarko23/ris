using System;
using System.Collections.Generic;
using System.Text;

namespace ris.Modeli
{
    internal class StavkaNarudzbe
    {
        public int narudzbaId { get; set; }
        public int artiklId { get; set; }
        public int kolicina { get; set; }
        public DateTime vrijeme {get; set; }

        public enum StatusEnum { Na_cekanju, U_pripremi, Gotovo}
        public StatusEnum status { get; set; }

        internal static StatusEnum Parse(string? v)
        {
            switch (v)
            {
                case "na_cekanju":
                    return StatusEnum.Na_cekanju;
                    break;
                case "u_pripremi":
                    return StatusEnum.U_pripremi;
                    break;
                case "gotovo":
                    return StatusEnum.Gotovo;
                    break;
            }
            return StatusEnum.Na_cekanju;
        }
    }
}
