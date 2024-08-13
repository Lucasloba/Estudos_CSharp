using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos 
{
    public enum Genero { Acao, Aventura, Terror, Animacao, Comedia }; //não poe nada de acento e é em pascal case

    public class Filme {
        public string Titulo;
        public Genero GeneroDoFilme;
    }

    class ExemploEnum 
    {
        public static void Executar () {
            int id = (int)Genero.Aventura;
            Console.WriteLine(id);

            var filmeParaFamilia = new Filme();
            filmeParaFamilia.Titulo = "Se eu fosse vc";
            filmeParaFamilia.GeneroDoFilme = Genero.Animacao;

            Console.WriteLine("{0} é {1}!", filmeParaFamilia.Titulo, filmeParaFamilia.GeneroDoFilme);
        }
    }
}

// nesse cod, foi-se enumedado o genero (acao 0, aventura 1, etc). Na segunda sentença, foi-se feita uma classificação 
// de um filme específico. Exemplo: avengrs é acao. o dev q define 
