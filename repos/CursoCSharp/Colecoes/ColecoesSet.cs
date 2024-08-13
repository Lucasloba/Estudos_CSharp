using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes 
{
    class ColecoesSet
    {
        public static void Executar() {
            var livro = new Produto("Game of Thrones", 49.9);

            var carrinho = new HashSet<Produto>();
             //list GENERICS pq o criador criou para ser uma lista "qlqr"/generica
            carrinho.Add(livro);                //pq o uso da lista em si é específico.

            var combo = new HashSet<Produto> { // pode ser uma uniao com lista ou com set msm, n dá problema
                new Produto("Camisa", 29.9),
                new Produto("8ª Temporda Game Of Thrones", 99.9),
                new Produto("Poster", 10),
                new Produto("Poster", 10)
                // livro 
            };

            carrinho.UnionWith(combo); //"union" altera o carrinho para unir ao conjunto combo que vc criou
            Console.WriteLine(carrinho.Count);
            // carrinho.RemoveAt(2); set n aceita 

            foreach (var item in carrinho) {
                // Console.Write(carrinho.IndexOf(item)); set n aceita (ele n é indexado)
                Console.WriteLine($" {item.Nome} {item.Preco}");
            }

            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro);
            Console.WriteLine(carrinho.Count);
            // Console.WriteLine(carrinho.LastIndexOf(livro));
        }
    }
}
