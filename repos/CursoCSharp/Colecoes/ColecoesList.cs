using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes 
{
    public class Produto {
        public string Nome;
        public double Preco;

        public Produto(string nome, double preco) {
            Nome = nome;
            Preco = preco;
        }
    }

    class ColecoesList 
    {
        public static void Executar() {
            var livro = new Produto("Game of Thrones", 49.9);

        var carrinho = new List<Produto>();     //list GENERICS pq o criador criou para ser uma lista "qlqr"/generica
            carrinho.Add(livro);                //pq o uso da lista em si é específico.

            var combo = new List<Produto> {
                new Produto("Camisa", 29.9),
                new Produto("8ª Temporda Game Of Thrones", 99.9),
                new Produto("Poster", 10)
            };

            carrinho.AddRange(combo); //AddRange é um método para criar um carrinho dentro de outro carrinho
            Console.WriteLine(carrinho.Count);
            carrinho.RemoveAt(2);

            foreach (var item in carrinho) {
                Console.Write(carrinho.IndexOf(item));
                Console.WriteLine($" {item.Nome} {item.Preco}");
            }

            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro);
            Console.WriteLine(carrinho.LastIndexOf(livro));
        }
    }
}
