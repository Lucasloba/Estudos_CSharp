using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteConstrutor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Batatinha batata = new Batatinha("palha");
            {
                batata.VcGostaDebatata = "gosto";
            }
        }
    }
}
