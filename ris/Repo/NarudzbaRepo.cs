using MySqlConnector;
using ris.Dll;
using ris.Forme.Jednostavne;
using ris.Modeli;
using ris.Repo.OK;
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
            var reader = MyDB.GetDataReader(upit);

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

            DateTime ispunjena;
            if (DateTime.TryParse(reader["ispunjena"].ToString(), out DateTime tempIspunjena))
            {
            ispunjena = DateTime.Parse(reader["ispunjena"].ToString());
            }
            else ispunjena = DateTime.MinValue;

            StatusEnum status = Narudzba.Parse(reader["status"].ToString());
  
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

        internal static void Delete(Narudzba? narudzba)
        {
           // var stavke = StavkaRepo.GetStavkeZaNarudzbu(narudzba.Id);
           // obrisi prvo stavke

            string upit = $"DELETE FROM narudzba WHERE id = {narudzba.Id}";
            MyDB.OpenConn();
            MyDB.Run(upit);
            MyDB.CloseConn();

        }

        internal static void Insert(Narudzba narudzba) { 
            string upit = $"INSERT INTO narudzba (zaprimio_id, zaprimljena, ispunjena, status, stol_id) " +
                $"VALUES ({narudzba.Zaprimio.Id}, '{narudzba.Zaprimljena.ToString("yyyy-MM-dd HH:mm:ss")}', " +
                $"{(narudzba.Ispunjena == DateTime.MinValue ? "NULL" : $"'{narudzba.Ispunjena.ToString("yyyy-MM-dd HH:mm:ss")}'")}, " +
                $"'{narudzba.Status}', {narudzba.Stol.Id})";

            MyDB.OpenConn();
            MyDB.Run(upit);
            MyDB.CloseConn();
        }

        internal static void Update(Narudzba narudzba)
        {
            string upit = $"UPDATE narudzba SET zaprimio_id = {narudzba.Zaprimio.Id}, " +
                $"zaprimljena = '{narudzba.Zaprimljena.ToString("yyyy-MM-dd HH:mm:ss")}', " +
                $"ispunjena = {(narudzba.Ispunjena == DateTime.MinValue ? "NULL" : $"'{narudzba.Ispunjena.ToString("yyyy-MM-dd HH:mm:ss")}'")}, " +
                $"status = '{narudzba.Status}', stol_id = {narudzba.Stol.Id} " +
                $"WHERE id = {narudzba.Id}";
            MyDB.OpenConn();
            MyDB.Run(upit);
            MyDB.CloseConn();
        }
    }
}
