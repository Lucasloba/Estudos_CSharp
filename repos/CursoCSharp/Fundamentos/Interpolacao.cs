using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class Interpolacao 
    {
        public static void Executar() {
            string nome = "Notebook Gamer";
            string marca = "Dell"; // poderia ser "var" tbm que o compilador iria inferir 
            double preco = 5800.00;

            Console.WriteLine("0 " + nome + " da marca " 
                + marca + " custa " + preco + "."); // concatenando variável com string 
                                                    // mas fazer ass smp pode ser chato, ent pode-se fzr de outros jeitos - interpolação

            //interpolação
            Console.WriteLine("0 {0} da marca {1} custa {2}.", // precisa da vírgula nesse caso 
                nome, marca, preco);

            // ou

            Console.WriteLine($"O nome {nome} é legal"); // serve com qlqr variável (nome, marca e preço)
            Console.WriteLine($"1 + 1 = {1 + 1}!"); // interpolou, ou interpretou, o valor entre chaves pra gerar resultados
        }
    }
}
