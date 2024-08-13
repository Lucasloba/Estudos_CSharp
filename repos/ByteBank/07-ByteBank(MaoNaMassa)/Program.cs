using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank_MaoNaMassa_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaMaoNaMassa = new ContaCorrente(694, 1015);

            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            Console.ReadLine();  
        }
    }
}
