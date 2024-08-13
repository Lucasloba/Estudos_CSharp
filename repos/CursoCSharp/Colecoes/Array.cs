using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {
    class Array {   // "string []alunos" notação válida tbm
        public static void Executar() {
            string[] alunos = new string[5]; //so pode ter um tipo dentro do array. se tem string, so pod ter 
            alunos[0] = "Andreson";          //string. é homogeneo. Array é static
            alunos[1] = "Bia";
            alunos[2] = "Carlos";
            alunos[3] = "Daniela";
            alunos[4] = "Emanuel";
            //  alunos[5] = "Emanuel"; oq tiver fora do array da erro na compilação

            foreach (var aluno in alunos) {
                Console.WriteLine(alunos);
            }

            double somatorio = 0;
            double[] notas = { 9.7, 4.8, 8.4, 8.2, 6.8 };

            foreach (var nota in notas) {
                somatorio += nota;
            }

            // for(int i = 0; i < notas.Length; i++) {
            //     somatorio += notas[i];
            //}

            double media = somatorio / notas.Length; // length - pega os valores de notas
            Console.WriteLine(media);

            char[] letras = { 'A', 'r', 'r', 'a', 'y' };
            string palavra = new string(letras);
            Console.WriteLine(palavra);
        }
    }
}
