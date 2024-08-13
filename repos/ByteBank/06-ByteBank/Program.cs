using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            Cliente cliente = new Cliente();

            cliente.Nome = "Lucas";
            cliente.CPF= "522.538.508-70";
            cliente.Profissao = "Desenvolvedor";

            // chamando a função "DefinirSaldo" ou Set - para definir o saldo 
            conta.Saldo = -10;
            conta.Titular = cliente;

            // imprimindo com outra função chamada "ObterSaldo" ou Get -
            // que retorna o saldo atual definido na função anterior =)
            Console.WriteLine(conta.Titular.Nome);
            Console.WriteLine(conta.Saldo);

            Console.ReadLine();
        }
    }
}
