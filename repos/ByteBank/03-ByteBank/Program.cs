using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 863;
            contaDaGabriela.numero = 863452;

            ContaCorrente contaDaGabrielaCosta = new ContaCorrente();
            contaDaGabrielaCosta.titular = "Gabriela";
            contaDaGabrielaCosta.agencia = 863;
            contaDaGabrielaCosta.numero = 863452;

            // -------------- Igualdade De Tipo De Referência -----------

            Console.WriteLine("Igualdade de tipo de referência: " + 
                (contaDaGabriela == contaDaGabrielaCosta)); 

            // -------------- Igualdade De Tipo De Valor ----------------

            int idade = 27;
            int idadeMaisUmaVez = 27;

            Console.WriteLine("Igualdade de tipo de valor: " + 
                (idade == idadeMaisUmaVez));

            // --------------------------------------------------------

            contaDaGabriela = contaDaGabrielaCosta;
            Console.WriteLine("Atribuição direta: " + (contaDaGabriela == contaDaGabrielaCosta));

            contaDaGabriela.saldo = 300;
            Console.WriteLine(contaDaGabriela.saldo);
            Console.WriteLine(contaDaGabrielaCosta.saldo); // esse saldo será o da Gabriela pois 
            // na linha 38 eu atribui contaDaGabriela para contaDaGabrielaCosta. Se eu n tivesse 
            // feito isso, o valor do saldo da Costa seria o valor padrao 100 (sabendo qua eu n 
            // tinha definido valor para o saldo dela anteriormente). 

            Console.ReadLine();
            
            /*
                   ---------------------- LIÇÃO DE CASA ----------------------------

            ContaCorrente primeiraContaCorrente = new ContaCorrente();

            primeiraContaCorrente.saldo = 200;
            Console.WriteLine(primeiraContaCorrente.saldo);

            primeiraContaCorrente.saldo += 100;
            Console.WriteLine(primeiraContaCorrente.saldo);

            ContaCorrente segundaContaCorrente = new ContaCorrente();

            segundaContaCorrente.saldo = 50;

            Console.WriteLine("a primeira conta tem: " + primeiraContaCorrente.saldo);
            Console.WriteLine("a segunda conta tem: " + segundaContaCorrente.saldo);


            Console.ReadLine();

            */
        }
    }
}
