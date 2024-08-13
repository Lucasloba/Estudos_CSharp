using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGabriela = new ContaCorrente();

            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 863;
            contaDaGabriela.numero = 863452;
            contaDaGabriela.saldo = 100;
            
            Console.Write("Tirular: " + contaDaGabriela.titular + "\n");
            Console.Write("Agência: " + contaDaGabriela.agencia + "\n");
            Console.Write("Número: " + contaDaGabriela.numero + "\n");
            Console.Write("Saldo: " + contaDaGabriela.saldo + "\n");

            contaDaGabriela.saldo += 200;
            Console.Write("Saldo: " + contaDaGabriela.saldo + "\n");



            Console.ReadLine();
        }
    }
}
