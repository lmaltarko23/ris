using ris.Dll;
using System;
using System.Collections.Generic;
using System.Text;
using MySqlConnector;
using ris.Modeli.OK;


namespace ris.Repo.OK
{
    internal class ArtiklRepo
    {
        public static Artikl GetArtikl(int id) {
            Artikl artikl = null;
            string upit = $"SELECT * FROM artikli WHERE id = {id}";
            MyDB.OpenConn();
            var reader = MyDB.GetDataReader(upit);

            if (reader.HasRows) {
                reader.Read();
                artikl = CreateObj(reader);
                reader.Close();
            }

            reader.Close();
            MyDB.CloseConn();
            return artikl;
        }

        public static List<Artikl> GetArtikli() {
            List<Artikl> artikli = new List<Artikl>();

            string upit = "SELECT * FROM artikl";
            MyDB.OpenConn();
            var reader = MyDB.GetDataReader(upit);

            while (reader.Read()) {
                Artikl artikl = CreateObj(reader);
                artikli.Add(artikl);
            }

            reader.Close();
            MyDB.CloseConn();

            return artikli;
        }

        public static Artikl CreateObj(MySqlDataReader reader) { 
            int id = int.Parse(reader["id"].ToString());
            string Naziv = reader["naziv"].ToString();
            string Opis = reader["opis"].ToString();
            float Cijena = float.Parse(reader["cijena"].ToString());
            bool Dostupan = bool.Parse(reader["dostupan"].ToString());

            var artikl = new Artikl
            {
                Id = id,
                Naziv = Naziv,
                Opis = Opis,
                Cijena = Cijena,
                Dostupan = Dostupan
            };

            return artikl;
        }
        public static void Insert(Artikl novi)
        {
            if (novi.Kategorija == null)
                throw new ArgumentException("Kategorija must be selected before inserting artikl.");

            string upit = $"INSERT INTO artikl (naziv, cijena, opis, kategorija_id) VALUES ('{novi.Naziv}', {novi.Cijena}, '{novi.Opis}', {novi.Kategorija.Id})";
            MyDB.OpenConn();
            MyDB.Run(upit);
            MyDB.CloseConn();
        }

        public static void Delete(Artikl stari)
        {
            string upit = $"DELETE FROM artikl WHERE id = {stari.Id}";
            MyDB.OpenConn();
            MyDB.Run(upit);
            MyDB.CloseConn();
        }
    }
}
