using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using MySqlConnector;
using ris.Dll;
using ris.Modeli;

namespace ris.Repo
{
    internal class DjelatnikRepo
    {
        public static Djelatnik GetDjelatnik(int id) {
            Djelatnik djelatnik = null;
            string upit = $"SELECT * FROM djelatnik WHERE id = {id}";
            MyDB.OpenConn();
            var reader = MyDB.GetDataReader(upit);

            if (reader.HasRows) {
                reader.Read();
                djelatnik = CreateObject(reader);
                reader.Close();
            }

            MyDB.CloseConn();
            return djelatnik;
        }

        public static List<Djelatnik> GetDjelatnici() {
            List<Djelatnik> djelatnici = new List<Djelatnik>();

            string upit = "SELECT * FROM djelatnik";
            MyDB.OpenConn();
            var reader = MyDB.GetDataReader(upit);

            while (reader.Read()) {
                Djelatnik djelatnik = CreateObject(reader);
                djelatnici.Add(djelatnik);
            }

            reader.Close();
            MyDB.CloseConn();

            return djelatnici;
        }

        private static Djelatnik CreateObject(MySqlDataReader reader) {
            int id = int.Parse(reader["id"].ToString());
            long oib = long.Parse(reader["oib"].ToString());
            string ime = reader["ime"].ToString();
            string prezime = reader["prezime"].ToString();
            //int uloga_id
            bool aktivan = bool.Parse(reader["aktivan"].ToString());

            var djelatnik = new Djelatnik {
                Id = id, Oib = oib,
                Ime = ime, Prezime = prezime,
                Uloga = 0, Aktivan = aktivan

            };

            return djelatnik;
        }
    }
}
