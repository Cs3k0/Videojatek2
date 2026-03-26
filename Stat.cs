using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Videojatek2
{
    public class Stat
    {
        public List<Videojatekok> jatekok;

        public Stat()
        {
            jatekok = new List<Videojatekok>();
            try
            {
                Query query = new Query();
                jatekok = query.GamesQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"db hiba\n{ex.Message}");

            }
            

            foreach(var jatek in jatekok)
            {
                Console.WriteLine($"{jatek.Name}");
            }
        }
    }
}
