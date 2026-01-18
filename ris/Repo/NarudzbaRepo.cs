using MySqlConnector;
using ris.Dll;
using ris.Forme.Jednostavne;
using ris.Modeli;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using static ris.Modeli.Narudzba;

namespace ris.Repo
{
    internal class NarudzbaRepo
    {
        public static Narudzba GetNarudzba(int id) {
            Narudzba narudzba = null;
            string upit = $"SELECT * FROM narudzba WHERE id = {id}";
            MyDB.OpenConn();
            var reader = MyDB.GetDataReader(upit);

            if (reader.HasRows) {
                reader.Read();
                narudzba = CreateObj(reader);
            }
            reader.Close();
            MyDB.CloseConn();

            return narudzba;
        }
        public static List<Narudzba> GetNarudzbe() {
            var narudzbe = new List<Narudzba>();

            string upit = "SELECT * FROM narudzba";
            MyDB.OpenConn();
            var reader = MyDB.GetDataReader();

            while (reader.Read()) {
                Narudzba narudzba = CreateObj(reader);
                narudzbe.Add(narudzba);
            }

            reader.Close();
            MyDB.CloseConn();

            return narudzbe;
        }

        public static Narudzba CreateObj(MySqlDataReader reader) {
            int id = int.Parse(reader["id"].ToString());
            int zaprimioId = int.Parse(reader["zaprimio_id"].ToString());
            DateTime zaprimljena = DateTime.Parse(reader["zaprimljena"].ToString());
            DateTime ispunjena = DateTime.Parse(reader["ispunjena"].ToString());
            int status = int.Parse(reader["id"].ToString());        // POTENCIJALNI PROBLEM!!!!!!! INT ILI ENUM?
            int stolId = int.Parse(reader["stol_id"].ToString());

            var zaprimio = DjelatnikRepo.GetDjelatnik(zaprimioId);
            var stol = StolRepo.GetStol(stolId);

            var narudzba = new Narudzba
            {
                Id = id,
                Zaprimio = zaprimio,
                Zaprimljena = zaprimljena,
                Ispunjena = ispunjena,
                Status = (StatusEnum)status,
                Stol = stol
            };

            return narudzba;
        }
    }
}
