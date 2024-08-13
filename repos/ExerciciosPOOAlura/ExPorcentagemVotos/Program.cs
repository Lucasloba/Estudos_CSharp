using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExPorcentagemVotos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EXERCICIO: PORCENTAGEM DE VOTOS 

            double totalVotos, voB, voN, voV, operacaoB, operacaoN, operacaoV;

            Console.WriteLine("Insira o número de votos válidos :");
            voV = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Insira o número de votos brancos :");
            voB = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Insira o número de votos nulos :");
            voN = Convert.ToDouble(Console.ReadLine());

            totalVotos = voB + voN + voV;

            operacaoV = voV * 100 / totalVotos;
            operacaoB = voB * 100 / totalVotos;
            operacaoN = voN * 100 / totalVotos;

            Console.WriteLine
                (
                "A quantidade total de votos é : " + totalVotos +
                ". sendo os válidos " + operacaoV +
                " %. Brancos : " + operacaoB +
                " %. E nulos : " + operacaoN +
                "%"
                );

            Console.ReadLine();
        }
    }
}
