using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExAnguloTriangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double an1, an2, an3;
          
            Console.WriteLine("Informe o valor do 1° ângulo em graus (º)");
            an1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o valor do 2° ângulo em graus (º)");
            an2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o valor do 3° ângulo em graus (º)");
            an3 = Convert.ToDouble(Console.ReadLine());

            if(an1 == 90 || an2 == 90 || an3 == 90)
            {
                Console.WriteLine("Retângulo");
            }
            else
            {
                if(an1 > 90 || an2 > 90 || an3 > 90)
                {
                    Console.WriteLine("Obtusângulo");
                }
                else
                {
                    if(an1 < 90 || an2 < 90 || an3 < 90)
                    {
                        Console.WriteLine("Acutângulo");
                    }
                }
            }
        }
    }
}
