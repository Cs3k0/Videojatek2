using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Videojatek2
{
    public class Query
    {
        public string ConnectionString = "server=localhost;port=3306;database=videojatek_bolt;" + "user id=root;password=;";

        public List<Videojatekok> GamesQuery()
        {
            List<Videojatekok> result = new List<Videojatekok>();
            MySqlConnection conn = new MySqlConnection(ConnectionString);
            conn.Open();

            string sql = "SELECT * FROM jatekok";
            MySqlCommand mySqlCommand = new MySqlCommand(sql, conn);
            MySqlDataReader reader = mySqlCommand.ExecuteReader();

            while (reader.Read())
            {
                int Id = reader.GetInt32("id");
                string Name = reader.GetString("nev");
                int Ar = reader.GetInt32("ar");
                string Kategoria = reader.GetString("kategoria");
                bool Felnott = reader.GetBoolean("felnott");

                Videojatekok jatek = new Videojatekok(Id, Name, Ar, Kategoria, Felnott);
                result.Add(jatek);
            }
            return result;
        }
    }
}
