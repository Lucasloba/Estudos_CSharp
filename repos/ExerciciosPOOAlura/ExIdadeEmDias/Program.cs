using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExIdadeEmDias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EXERCICIO: SUA IDADE EM DIAS

            int anoN, mesN, diaN, anoA, mesA, diaA, operacao;

            Console.WriteLine("ano q c nasceu ");
            anoN = int.Parse(Console.ReadLine());

            Console.WriteLine("mes q c nasceu em numero");
            mesN = int.Parse(Console.ReadLine());

            Console.WriteLine("dia q c nasceu em numero");
            diaN = int.Parse(Console.ReadLine());

            Console.WriteLine("ano atual");
            anoA = int.Parse(Console.ReadLine());

            Console.WriteLine("mes atual em numero");
            mesA = int.Parse(Console.ReadLine());

            Console.WriteLine("dia atual em numero");
            diaA = int.Parse(Console.ReadLine());

            operacao = (anoA - anoN) * 365 + (mesA - mesN) * 30 + (diaA - diaN) + 2;

            Console.WriteLine("a quantidade de dias de vida q c tem é: " + operacao);
        }
    }
}
