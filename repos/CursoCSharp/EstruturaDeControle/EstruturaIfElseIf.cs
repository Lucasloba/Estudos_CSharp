using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle {
    internal class EstruturaIfElseIf {
        public static void Executar() {
            Console.Write("Digite a nota do aluno: ");

            string entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            if (nota >= 9.0) {                             // vai executar o primeiro "if". se n for ele, vai para o else                                                      //
                Console.WriteLine("Quadro de Honra!");     // que tem o próprio if e assim vai ate a condição ser atendida.
            } else if (nota >= 7.0) {
                Console.WriteLine("Aprovado!");
            } else if (nota >= 5.0) {
                Console.WriteLine("Recuperação");
            } else {
                Console.WriteLine("Te vejo na próxima...");
            }

        }
    }
}