using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
                                                   //ag  //numero
            ContaCorrente conta = new ContaCorrente(867, 86712540);
       
            Console.WriteLine("ag: " + conta.Agencia);
            Console.WriteLine("numero: " + conta.Numero);

            ContaCorrente ContaDaGabriela = new ContaCorrente(867, 86712540);
            ContaCorrente ContaTeste = new ContaCorrente(7, 8);

            Console.WriteLine("O total de conta é: " + ContaCorrente.TotalDeContasCriadas);
            Console.ReadLine();
        }
    }
}
