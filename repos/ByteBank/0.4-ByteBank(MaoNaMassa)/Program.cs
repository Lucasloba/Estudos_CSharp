using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._4_ByteBank_MaoNaMassa_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaMaoNaMassa = new ContaCorrente();
            ContaCorrente contaMassaNaMao = new ContaCorrente();

            contaMaoNaMassa.titular = "Mão Na Massa";
            Console.WriteLine(contaMaoNaMassa.titular);

            contaMaoNaMassa.Sacar(20);
            Console.WriteLine("Saquei 20 da contaMaoNaMassa, ficou: " + contaMaoNaMassa.saldo);

            contaMaoNaMassa.Depositar(10);
            Console.WriteLine("Depositei 10 na contaMaoNaMassa, ficou: " + contaMaoNaMassa.saldo);

            contaMaoNaMassa.Transferir(40, contaMassaNaMao);
            Console.WriteLine("Tinha 90 na contaMaoNaMassa e depositei 40 na ContaMassaNaMao, ficou: " 
                + contaMaoNaMassa.saldo + " na contaMaoNaMassa");
            Console.WriteLine("Tinha 100 na contaMassaNaMao e recebeu 40 da contaMaoNaMassa, ficou: " 
                + contaMassaNaMao.saldo + " na contaMassaNaMao");

        }
    }
}
