using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExAreaCirculo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A, R;
            double pi = 3.14;

            Console.WriteLine("Informe o valor do raio");
            R = Convert.ToDouble(Console.ReadLine());

            A = pi * Math.Pow(R,2);


            Console.WriteLine("O valor da área é: " + A);
        }
    }
}
