using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Videojatek2
{
    public class Videojatekok
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Ar { get; set; }
        public string Kategoria { get; set; }
        public bool Felnott { get; set; }

        public Videojatekok(int id, string name, int ar, string kategoria, bool felnott)
        {
            Id = id;
            Name = name;
            Ar = ar;
            Kategoria = kategoria;
            Felnott = felnott;
        }
    }
}
