using System;                    // LINQ = LINGUAGEM DE CONSULTA INEGRADA 
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.TopicosAvancados 
{
    public class Aluno {
        public string Nome;
        public int Idade;
        public double Nota;
    }

    class LINQ1 
    {
        public static void Executar() {
            var alunos = new List<Aluno> {
                 new Aluno { Nome = "Pedro", Idade = 24, Nota =  8.0 },
                 new Aluno { Nome = "Andre", Idade = 21, Nota = 4.3 },
                 new Aluno { Nome = "Ana", Idade = 25, Nota = 9.5 },
                 new Aluno { Nome = "Jorge", Idade = 20, Nota = 8.5 },
                 new Aluno { Nome = "Ana Paula", Idade = 21, Nota = 7.7 },
                 new Aluno { Nome = "Julia", Idade = 22, Nota = 7.5 },
                 new Aluno { Nome = "Marcio", Idade = 18, Nota = 6.8 },
            };

            Console.WriteLine("== Aprovados ==============");
            var aprovados = alunos.Where(a => a.Nota >= 7) // where é dizer o criterio para aprovação 
                .OrderBy(a => a.Nome); // orderby é como vc diz q a lista deve ficar ordenada
            foreach (var aluno in aprovados) { 
                Console.WriteLine(aluno.Nome);
            }

            Console.WriteLine("\n== Chamada ==============");
            var chamada = alunos.OrderBy(a => a.Nome).Select(a => a.Nome);
            foreach (var aluno in chamada) {
                Console.WriteLine(aluno);
            }

            Console.WriteLine("\n== Aprovados (por Idade) ==================");
            var alunosAprovados = from aluno in alunos
                                  where aluno.Nota >= 7
                                  orderby aluno.Idade
                                  select aluno.Nome; 

            foreach (var aluno in alunosAprovados) {
                Console.WriteLine(aluno);
            }
        }
    }                                                              // varia formas de fzr listagem 
}
