using System;                       //crie uma classe pra cada exercicio
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosPOOAlura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //----------------------------------------------
            //EXERCICIO: IF, COMPARAÇÃO NUMERO

            double val1, val2;

            Console.WriteLine("insira um número");
            val1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("outro numero um número");
            val2 = Convert.ToDouble(Console.ReadLine());

            if (val1 == val2)
            {
                Console.WriteLine("O maior número é: " + val1);
            }
            else
            {
                Console.WriteLine("O maior número é: " + val2);
            }
        }
    }
}
