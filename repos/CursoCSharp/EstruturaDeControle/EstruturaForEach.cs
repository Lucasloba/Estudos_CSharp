using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle {
    internal class EstruturaForEach {
        public static void Executar() {
            var palavra = "rapaiz!";

            foreach (var letra in palavra) {
                Console.WriteLine(letra);
            }

            var alunos = new string[] { "Rayssa", "Lucas", "diamante" };
            foreach (var aluno in alunos) { //var ou string pq o c# sabe q dentro tem alunos
                Console.WriteLine(aluno);
            }
        }
    }
}
