using System;
using System.Collections.Generic;
using System.Text;
using MySqlConnector;
using ris.Dll;
using ris.Modeli;
using static ris.Modeli.Kategorija;


namespace ris.Repo
{
    internal class KategorijaRepo
    {
        public static Kategorija GetKategorija(int id) {
            Kategorija kategorija = null;
            string upit = $"SELECT * FROM katgorija WHERE id = {id}";
            MyDB.OpenConn();
            var reader = MyDB.GetDataReader(upit);

            if (reader.HasRows) {
                reader.Read();
                kategorija = NewObj(reader);
                reader.Close();
            }

            MyDB.CloseConn();
            return kategorija;
        }

        public static List<Kategorija> GetKategorije() {
            List<Kategorija> kategorije = new List<Kategorija>();

            string upit = "SELECT * FROM kategorija";
            MyDB.OpenConn();
            var reader = MyDB.GetDataReader(upit);

            while (reader.Read()) {
                Kategorija kategorija = NewObj(reader);
                kategorije.Add(kategorija);
            }

            reader.Close();
            MyDB.CloseConn();

            return kategorije;
        }

        public static Kategorija NewObj(MySqlDataReader reader) { 
            int id = int.Parse(reader["id"].ToString());
            string naziv = reader["naziv"].ToString();
            string opis = reader["opis"].ToString();

            Kategorija kategorija = new Kategorija
            {
                Id = id,
                Naziv = naziv,
                Opis = opis
            };

            return kategorija;
        }

        public static void Insert(Kategorija nova) { 
            string upit = $"INSERT INTO kategorija (naziv, opis) VALUES ('{nova.Naziv}', '{nova.Opis}')";
            MyDB.OpenConn();
            MyDB.Run(upit);
            MyDB.CloseConn();
        }

        public static void Delete(Kategorija stara) {
            string upit = $"DELETE FROM kategorija WHERE id = {stara.Id}";
            MyDB.OpenConn();
            MyDB.Run(upit);
            MyDB.CloseConn();
        }
    }
}
