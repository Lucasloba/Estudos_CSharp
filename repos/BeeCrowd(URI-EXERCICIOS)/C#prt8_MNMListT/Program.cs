using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_prt8_MNMListT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SlaMano();
            //ListMetodos();
            //UsoDoVar();
        }

        static void ListMetodos()
        {
            List<int> idades = new List<int>();

            //ListExtensoes.AdicionarVarios(idades, 1, 5, 14, 25, 38, 61); jeito mlr abaixo

            idades.AdicionarVarios(1, 5, 14, 25, 38, 61);

            idades.Add(1);
            idades.Add(5);
            idades.Add(14);
            idades.Add(25);
            idades.Add(38);
            idades.Add(61);

            idades.Remove(5);

            for (int i = 0; i < idades.Count; i++)
            {
                Console.WriteLine(idades[i]);
            }

            List<int> idades2 = new List<int>();
            idades.AdicionarVarios(1, 5, 14, 25, 38, 61);

            List<string> nomes = new List<string>();
            nomes.AdicionarVarios("Lucas", "Rayssa");

            for (int i = 0; i < nomes.Count; i++)
            {
                Console.WriteLine(nomes[i]);
            }
        }

        static void UsoDoVar()
        {
            var nomes = new List<string>()
            {
                "Vinícius",
                "Gisele",
                "Mayra",
                "Vasco"
            };

            nomes.Sort();

            foreach (var nome in nomes)
            {
                Console.WriteLine(nome);
            }
        }

        static void SlaMano()
        {
            var coisas = new List<object>()
            {
                "string",
                24,
                true
            };

            foreach (var coisa in coisas)
            {
                Console.WriteLine($"O tipo deste item na lista é: {coisa.GetType()}");

            }
        }
    }
}
