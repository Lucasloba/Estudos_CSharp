using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    class ColecoesQueue {
        public static void Executar() { //first in, first out - princípio 
            var fila = new Queue<string>();

            fila.Enqueue("Fulano"); //enqueue enfilera e dequeue
            fila.Enqueue("Sicrano");
            fila.Enqueue("Beltrano");

            Console.WriteLine(fila.Peek()); // vai pegar o primeiro da fila e exibir 
            Console.WriteLine(fila.Count);  // tem 3 elementos na lista e "fulano" ainda é o primeiro 

            Console.WriteLine(fila.Dequeue()); // desenfilera "fulano" fazendo com que so restem dois elementos na fila 
            Console.WriteLine(fila.Count);

            foreach(var pessoa in fila) {
                Console.WriteLine(pessoa);
            }

            var salada = new Queue();
            salada.Enqueue(3);
            salada.Enqueue("eu amo a rayssa?");
            salada.Enqueue(false);
            salada.Enqueue(2.71);

            Console.WriteLine(salada.Contains("Eu amo a rayssa?")); // verifica se o atributo está na lista
            Console.WriteLine(salada.Contains("eu amo a rayssa?"));

        }
    }
}
