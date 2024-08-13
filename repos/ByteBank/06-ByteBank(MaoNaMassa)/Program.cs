using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank_MaoNaMassa_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente minhaConta = new ContaCorrente();
            Cliente euMesmo = new Cliente();

            euMesmo.Nome = "Lucas";
            euMesmo.CPF = 5579;
        }
    }
}
