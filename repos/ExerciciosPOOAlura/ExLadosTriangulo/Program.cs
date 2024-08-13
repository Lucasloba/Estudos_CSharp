using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExLadosTriangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double medidaLado1;
            double medidaLado2;
            double medidaLado3;

            Console.WriteLine("informe a medida do lado 1 em cm");
            medidaLado1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("informe a medida do lado 2 em cm");
            medidaLado2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("informe a medida do lado 3 em cm");
            medidaLado3 = Convert.ToDouble(Console.ReadLine());

            if(medidaLado1 == medidaLado2)
            {
                if(medidaLado2 == medidaLado3)
                {
                    Console.WriteLine("Equilátero");
                }
                else
                {
                    Console.WriteLine("Isócele");
                }
            }
            else
            {
                if(medidaLado2 == medidaLado3)
                {
                    Console.WriteLine("Isóceles");
                }
                else
                {
                    Console.WriteLine("Escaleno");
                }
            }
        }
    }
}
