using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle {
    internal class EstruturaIfElse 
    {
        public static void Executar () {
            double nota = 6.0; // nota do aluno 

            if (nota >= 7.0) { // condição de verdade 
                Console.WriteLine("Aprovado");
                Console.WriteLine("Não fez mais que sua obrigação"); // smp if ou else serão executados, nunca os dois ao msm tmp
            } else {  // preferívelmente sempre fechar o código " } else { "
                Console.WriteLine("Recuperação");
            }
        }
    }
}
