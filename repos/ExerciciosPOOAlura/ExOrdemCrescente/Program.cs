using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExOrdemCrescente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // incompleto, ainda n funciona 
            int val1, val2, val3;

            Console.WriteLine("insira um numero");
            val1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("insira um numero diferente do anterior");
            val2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("insira um numero diferente dos anteriores");
            val3 = Convert.ToInt32(Console.ReadLine());

            if(val1 < val2)
            {
                if (val2 < val3) 
                {
                    Console.WriteLine("Ordem Crescente: " + val1, val2, val3);
                }
                else
                {
                    Console.WriteLine("Ordem Crescente: " + val1, val3, val2);
                }
            }
            else
            {
                if(val1 < val3)
                {
                    Console.WriteLine("Ordem Crescente: " + val2, val1, val3);
                }
                else
                {
                    Console.WriteLine("Ordem Crescente: " + val2, val3, val1);
                }
            }
        }
    }
}
