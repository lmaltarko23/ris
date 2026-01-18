using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using MySqlConnector;
using ris.Dll;
using ris.Modeli.OK;
using static ris.Modeli.OK.Stol;

namespace ris.Repo.OK
{
    internal class StolRepo
    {
        public static Stol GetStol(int id) {
            Stol stol = null;
            string upit = $"SELECT * FROM stol WHERE Id = {id}";
            MyDB.OpenConn();
            var reader = MyDB.GetDataReader(upit);

            if (reader.HasRows) {
                reader.Read();
                stol = CreateObject(reader);
                reader.Close();
            }

            MyDB.CloseConn();
            return stol;
        }

        public static List<Stol> GetStolovi() { 
            List<Stol> stolovi = new List<Stol>();

            string upit = "SELECT * FROM stol";
            MyDB.OpenConn();
            var reader = MyDB.GetDataReader(upit);

            while (reader.Read()) {
                Stol stol = CreateObject(reader);
                stolovi.Add(stol);
            }

            reader.Close();
            MyDB.CloseConn();

            return stolovi;
        }

        public static Stol CreateObject(MySqlDataReader reader)
        {
            int id = int.Parse(reader["id"].ToString());
            string opis = reader["opis"].ToString();
            int mjesta = int.Parse(reader["mjesta"].ToString());
            Enum.TryParse<Statusi>(reader["status"].ToString(), true, out Statusi status);

            var stol = new Stol
            {
                Id = id,
                Opis = opis,
                Mjesta = mjesta,
                Status = status
            };

            return stol;
        }
    }
}
