using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExSenhaIfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int senha = 1234;
            int tentativa;

            Console.WriteLine("Insira a senha");
            tentativa = Convert.ToInt32(Console.ReadLine());

            if(senha == tentativa)
            {
                Console.WriteLine("ACESSO PERMITIDO");
            }
            else
            {
                Console.WriteLine("ACESSO NEGADO");
            }

        }
    }
}
