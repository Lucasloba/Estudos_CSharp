using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank_MaoNaMassa_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // instanciando a referencia criada aq e agr "contaDaRayssa" no objeto "ContaCorrente"
            ContaCorrente contaDaRayssa = new ContaCorrente();

            // instanciando a referencia "contaDaRayssa" ao atributo "titular"
            // que está instanciado ao objeto "Cliente". Onde está instanciado?
            // na classe ContaCorrente! =)
            contaDaRayssa.titular = new Cliente();

            // declarando um valor ao atriburo "nome" que pertence ao obejto
            // "Cliente" que está instanciado ao "titular" na classe ContaCorrente 
            contaDaRayssa.titular.nome = "Rayssa";

            // Imprimindo no console
            Console.WriteLine(contaDaRayssa.titular.nome);
        }
    }
}
