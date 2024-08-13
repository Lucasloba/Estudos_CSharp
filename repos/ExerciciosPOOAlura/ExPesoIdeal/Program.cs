using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExPesoIdeal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double altura;
            int sexo;
            double pesoIdeal;

            Console.WriteLine("Insira sua altura em cm");
            altura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Insira o dígito que corresponde ao seu sexo:" +
                " 1 para feminino ou 2 para masculino");
            sexo = Convert.ToInt32(Console.ReadLine());

            if(sexo == 1)
            {
                pesoIdeal = altura * 0.675 - 56.25 ;
                Console.WriteLine("O seu peso ideal é: " + pesoIdeal);
            }
            else 
            {
                if(sexo == 2)
                {
                    pesoIdeal = altura * 0.75 - 62.5;
                    Console.WriteLine("O seu peso ideal é: " + pesoIdeal + "kg");
                }
            }

            Console.ReadLine();
        }
    }
}
