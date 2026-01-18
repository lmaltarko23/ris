using MySqlConnector;
using ris.Dll;
using ris.Modeli;
using System;
using System.Collections.Generic;
using System.Text;
using static ris.Modeli.StavkaNarudzbe;

namespace ris.Repo
{
    internal class StavkaNarudzbeRepo
    {
        public static StavkaNarudzbe GetStavka(int idStavke, int idArtikla) {
            StavkaNarudzbe stavka = null;
            string upit = $"SELECT * FROM stavka_narudzbe WHERE narudzba_id = {idStavke} AND artikl_id = {idArtikla}";
            MyDB.OpenConn();
            var reader = MyDB.GetDataReader(upit);
            if (reader.HasRows) {
                reader.Read();
                stavka = CreateObj(reader);
            }
            reader.Close();
            MyDB.CloseConn();
            return stavka;
        }

        public static List<StavkaNarudzbe> GetStavkeNarudzbe(int idNarudzbe) {
            var lista = new List<StavkaNarudzbe>();
            string upit = $"SELECT * FROM stavka_narudzbe WHERE id_narudzbe = {idNarudzbe}";
            MyDB.OpenConn();
            var reader = MyDB.GetDataReader(upit);
            if (reader.HasRows) {
                while (reader.Read()) {
                    var narudzba = CreateObj(reader);
                    lista.Add(narudzba);
                }
            }
            reader.Close();
            MyDB.CloseConn();
            return lista;
        }
        public static StavkaNarudzbe CreateObj(MySqlDataReader reade) {
            int narudzbaId = int.Parse(reade["narudzba_id"].ToString());
            int artiklId = int.Parse(reade["artikl_id"].ToString());
            int kolicina = int.Parse(reade["kolicina"].ToString());
            DateTime vrijeme = DateTime.Parse(reade["vrijeme"].ToString());

            StatusEnum status = StavkaNarudzbe.Parse(reade["status"].ToString());

            var stavka = new Modeli.StavkaNarudzbe
            {
                NarudzbaId = narudzbaId,
                ArtiklId = artiklId,
                Kolicina = kolicina,
                Vrijeme = vrijeme,
                Status = status
            };

            return stavka;
        }
    }
}
