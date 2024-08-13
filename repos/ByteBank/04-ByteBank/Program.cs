using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {        // instanciando o objeto ContaCorrente à referencia contaDoBruno
            ContaCorrente contaDoBruno = new ContaCorrente();

                 // acessando o atributo "titular"
            contaDoBruno.titular = "Bruno"; //coisa "fisica" q vc armazena algo 

            Console.WriteLine(contaDoBruno.saldo);
                 // chamando a função "Sacar"
            bool resultadoSaque = contaDoBruno.Sacar(500);
            Console.WriteLine(contaDoBruno.saldo);
            Console.WriteLine(resultadoSaque);

                 // chamando a função "Depositar"
            contaDoBruno.Depositar(500);
            Console.WriteLine(contaDoBruno.saldo);


            // ------------TRANSFERINDO-------------
            ContaCorrente contaDaGabriela = new ContaCorrente();

            contaDaGabriela.titular = "Gabriela";

            Console.WriteLine("Saldo do Bruno: " + contaDoBruno.saldo);
            Console.WriteLine("Saldo da Gabriela: " + contaDaGabriela.saldo);

            bool resutadoTransferencia = contaDoBruno.Transferir(50, contaDaGabriela);

            Console.WriteLine("Saldo do Bruno: " + contaDoBruno.saldo);
            Console.WriteLine("Saldo da Gabriela: " + contaDaGabriela.saldo);

            Console.WriteLine("Resultado da transferência: " + resutadoTransferencia);

            contaDaGabriela.Transferir(100, contaDoBruno);

            Console.WriteLine("Saldo do Bruno: " + contaDoBruno.saldo);
            Console.WriteLine("Saldo da Gabriela: " + contaDaGabriela.saldo);

            Console.ReadLine();
        }
    }
}
