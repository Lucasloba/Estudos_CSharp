using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle {
    internal class UsandoContinue 
    {
        public static void Executar () {
            int intervalo = 50;
            Console.WriteLine("Numeros pares entre 1 e {0}!", intervalo);

            for (int i = 1; i <= intervalo; i++) {
                if (i % 2 == 1) { // i %mod 2 = 1, ou seja, i é ímpar
                    continue; // != de "break", continue n fecha o bloco da execução, o cod continua executando
                }             // nesse caso, quando for par;

                Console.Write(i + " ");
            }
        }
    }
}
