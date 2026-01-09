using MySql.Data.MySqlClient;
using MarvelDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarvelDB.Data
{
    public class characters
    {
        public List<Character> GetAllUsers()
        {
            var list = new List<Character>();

            using (var conn = DBcon.GetConnection())
            {
                conn.Open();

                string query = "SELECT Name, Allias, ImageURL FROM characters";

                using (var cmd = new MySqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Character
                        {
                            Name = reader.GetString("Name"),
                            Allias = reader.GetString("Allias"),
                            ImageURL = reader.GetString("ImageURL")
                        });
                    }
                }
            }

            return list;
        }
    }
}
