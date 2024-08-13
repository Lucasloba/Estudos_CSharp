using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle {
    internal class EstruturaWhile {
        public static void Executar () {
            int palpite = 0;
            Random random = new Random(); //random == classe de valor aleatório

            int numeroSecreto = random.Next(1, 16); // gerar valor de 1 até 15 (16 n entra)
            bool numeroEncontrado = false;
            int tentativasRestantes = 5;
            int tentativas = 0; 

           // while(true) {

           // }

            while (tentativasRestantes > 0 && !numeroEncontrado) { //espressão smp true or false
                Console.WriteLine("Insira o seu palpite: ");
                string entrada = Console.ReadLine();
                int.TryParse(entrada, out palpite);

                tentativas++;
                tentativasRestantes--;

                if (numeroSecreto == palpite) {
                    numeroEncontrado = true;
                    var corAnterior = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("Numero encontrado em {0} tentativas",
                        tentativas);
                    Console.BackgroundColor = corAnterior;
                } else if (palpite > numeroSecreto) {
                    Console.WriteLine("Menor... Tente novamente!");
                    Console.WriteLine("Tentativas restantes: {0}", tentativasRestantes);

                } else {
                    Console.WriteLine("Maior... Tente novamente!");
                    Console.WriteLine("Tentativas restantes: {0}", tentativasRestantes);
                } 
            }
        }
    }
}
