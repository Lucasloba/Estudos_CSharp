using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExIdadeParaVotar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade;

            Console.WriteLine("Insira sua idade");
            idade = Convert.ToInt32(Console.ReadLine());

            if (idade >= 16)
            {
                Console.WriteLine("Esse ano vc poderá votar");
            }
            else
            {
                Console.WriteLine("Esse ano vc n poderá votar");
            }
        }
    }
}
