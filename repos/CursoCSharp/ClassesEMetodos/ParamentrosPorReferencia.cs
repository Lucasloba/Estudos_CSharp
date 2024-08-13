using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos 
{
    class ParametrosPorReferencia 
    {   
        public static void AlterarRef(ref int numero) {
            numero = numero + 1000;
        }

        public static void AlterarOut(out int numero1, out int numero2) {
            numero1 = 0;
            numero2 = 0;
            numero1 = numero1 + 15;
            numero2 = numero2 + 30;
        }

        public static void Executar() {
            int a = 3;
            AlterarRef(ref a);     // adicionar o "ref" em "alterar(a) faz com q o valor compilado (3) some-se
            Console.WriteLine(a);  // ao valor declaração inicialmente (1000) ficando, assim, 1003

            // int b;
            AlterarOut(out int b, out int c); // out serve para retornar valores alem do valor de "return" da função.
            Console.WriteLine($"{b} {c}");    // q nem nesse exemplo: ele retornou 2 valores. O c# so retorna 1 por padrão
                                              // o out serve como um auxiliador 
        }
    }
}
