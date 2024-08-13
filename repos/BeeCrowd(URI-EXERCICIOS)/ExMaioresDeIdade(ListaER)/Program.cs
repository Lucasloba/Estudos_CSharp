using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExMaioresDeIdade_ListaER_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade, mao = 0, contador;

            for(contador = 1; contador <= 10; contador++)
            {
                Console.WriteLine("Insira sua idade");
                idade = Convert.ToInt32(Console.ReadLine());
                if(idade >= 18)
                {
                    mao++;
                }
            }

            Console.WriteLine("A quantidade de pessoas maiores de idade é {0}", mao);
        }
    }
}
