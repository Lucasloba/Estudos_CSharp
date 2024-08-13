using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class Inferencia 
    {
        public static void Executar() {
            var nome = "Lucas"; // variavel "nome" é do tipo string
            // nome = 123;
            Console.WriteLine(nome);

            // int idade; 
            var idade = 17; // com "var" vc precisa inicializar dps de declarar a variável pro compilador entender/inferir o tipo da variável
            Console.WriteLine(idade);

            int a; // declaração de uma var (pd declarar e inicializar na próx linha) - n precisa colocar "int" dnv
            a = 3;
            int b = 2; // declaração + inicialização - ao msm tempo 

            Console.WriteLine(a + b);
            
        }

    }
}
