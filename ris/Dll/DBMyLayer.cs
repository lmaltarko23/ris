using System;
using System.Collections.Generic;
using System.Text;
using MySqlConnector;



namespace ris.Dll
{
    public static class MyDB
    {
        private static string _connectionString = @"Data Source=localhost;
Port=3306; Database=ris; User Id=ris; Password=ris; SslMode=None";
        private static MySqlConnection _connection;
        public static void OpenConn()
        {
            _connection = new MySqlConnection(_connectionString);
            _connection.Open();
        }
        public static void CloseConn()
        {
            if (_connection.State != System.Data.ConnectionState.Closed)
            {
                _connection.Close();
            }
        }
        public static MySqlDataReader GetDataReader(string query)
        {
            MySqlCommand command = new MySqlCommand(query, _connection);
            return command.ExecuteReader();
        }
        public static int Run(string sqlCommand)
        {
            MySqlCommand command = new MySqlCommand(sqlCommand, _connection);
            return command.ExecuteNonQuery();
        }
    }
}
