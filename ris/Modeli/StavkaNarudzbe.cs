using System;
using System.Collections.Generic;
using System.Text;

namespace ris.Modeli
{
    public class StavkaNarudzbe
    {
        public int NarudzbaId { get; set; }
        public int ArtiklId { get; set; }
        public int Kolicina { get; set; }
        public DateTime Vrijeme {get; set; }

        public enum StatusEnum { Na_cekanju, U_pripremi, Gotovo}
        public StatusEnum Status { get; set; }

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
