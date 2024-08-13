using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class OperadoresAritmeticos 
    {
        public static void Executar() {
            // Preço Deconto
            var preco = 1000.0;
            var imposto = 355;
            var desconto = 0.1;

            double total = preco + imposto; // se fosse int total, daria problema, sendo resolvido por int total = (int) preco + imposto;
            var totalComDesconto = total - (total * desconto ); // n necessariamente precisa de "()" pq multiplicação tem prioridade sob subtração
            Console.WriteLine("O preco final é {0}", totalComDesconto); // ou ($"O preco {totalComDesconto} é.")

            // IMC
            double peso = 91.2;
            double altura = 1.82;
            double imc = peso / Math.Pow(altura, 2);
            Console.WriteLine($"O IMC {imc} é." ); // ou  ("O IMC é {0}, imc = peso / Math.Pow(altura, 2)

            // Número Par/Impar
            int par = 24;
            int impar = 55;
            Console.WriteLine("{0}/2 tem resto {1}", par, par % 2);
            Console.WriteLine("{0}/2 tem resto {1}", impar, impar % 2);

            // string teste 
            string nome1 = "Lucas";
            string nome2 = "Rayssa";
            string resolt = "amor eterno";
            Console.WriteLine("{0} + {1} = {2}", nome1, nome2, resolt);
        }
    }
}
