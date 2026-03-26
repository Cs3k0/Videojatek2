using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Videojatek2
{
    public class Program
    {
        [STAThread]

        public static void Main(string[] args)
        {
            if (args.Length > 0 && args[0] == "--stat")
            {
                Stat stat = new Stat();
            }
            else
            {
                App.Main();
            }
        }
    }
}
