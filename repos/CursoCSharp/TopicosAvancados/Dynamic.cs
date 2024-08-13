using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.TopicosAvancados 
{
    class Dynamic 
    {
        public static void Executar() {
            dynamic meuObjeto = "teste";
            meuObjeto = 3;

            meuObjeto++; // adiciona um (atribuição aditiva) 
            Console.WriteLine(meuObjeto);

            dynamic aluno = new System.Dynamic.ExpandoObject();
            aluno.nome = "Maria Julia";
            aluno.nota = 8.9;
            aluno.idade = 24;

            Console.WriteLine($"{aluno.nome} {aluno.Nota} {aluno.idade}");
        }
    }
}
