using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1._10LivroAlg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = 0;

            while(a > b)
            {
                a = b - a;
                c++;
            }

            Console.WriteLine($"c -> {c}, a -> {a}");
            Console.ReadLine();
        }
    }
}
