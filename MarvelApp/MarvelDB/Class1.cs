using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarvelDB
{
    public class DBcon
    {
        private static readonly string _connectionString =
            "server=localhost;database=marvel_db;user=root;password=;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(_connectionString);
        }
    }
}
