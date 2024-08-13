using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes 
{
    class ColecoesStack 
    {
        public static void Executar () {
            var pilha = new Stack();

            pilha.Push(3);
            pilha.Push("dpc");
            pilha.Push(true);
            pilha.Push(2.71f);

            foreach (var item in pilha) {
                Console.Write($"{item} ");
            }

            Console.WriteLine($"\nPop: {pilha.Pop()}"); // "saca" o último item adicionado, retirando-o da lista

            foreach (var item in pilha) {
                Console.Write($"{item} "); //remove o ultimo item adicionado (2.71 true dpc 3 -> true dpc 3)
            }

            Console.WriteLine($"\nPeek: {pilha.Peek()}");
            Console.WriteLine(pilha.Count);
        }
    }
}
// primeiro a entrar é o último a sair