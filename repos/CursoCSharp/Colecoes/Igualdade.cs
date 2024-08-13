using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes 
{
    class Igualdade 
    { 
        public static void Executar() {
            var p1 = new Produto("Caneta", 1.89);
            var p2 = new Produto("Caneta", 1.89);
            var p3 = p2; // duas variáveis apontam pro mesmo local de memória / atrobuição p referência

            Console.WriteLine(p1 == p2); // p1 é difernte de p2 pq as duas variáveis tem referencias (nomes) diferentes.
            Console.WriteLine(p3 == p2); // p3 é igual (==) a p2 pq as referencias apontam pro mesmo local.

            Console.WriteLine(p1.Equals(p2)); // Equals: compara endereço de memoria (a referencia). Portanto, p1 ainda é /= de p2.
        }
    }
}
