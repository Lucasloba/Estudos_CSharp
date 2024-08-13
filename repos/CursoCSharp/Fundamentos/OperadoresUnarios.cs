using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class OperadoresUnarios {
        public static void Executar() {
            var valorNegativo = -5;
            var numero1 = 2;
            var numero2 = 3;
            var booleano = true;

            Console.WriteLine(-valorNegativo);
            Console.WriteLine(!booleano); // "!xxxxxx" inverte. ex: se é true vira false, e vice versa.

            numero1++;                   // "++" adiciona uma unidade ao valor inicial, q no caso, é 2. ficando "3"
            Console.WriteLine(numero1); 

            --numero1;                   // "--" tira uma unidade do valor inicial, q no caso, é 2. ficando "1"
            Console.WriteLine(numero1);

            Console.WriteLine(numero1++ == --numero2);      // "++" antes da var significa prioridade de execução. Dps da var significa n prioridade
            Console.WriteLine($"{numero1} {numero2}");      // na prática vai executar de boas, mas se for pra pedir especificidade, vai sergui a
                                                            // regra de prioridade;


            /* o objtv é entender q é primordial q os cods tenham boa leitura, isso ajuda a melhorar
             * para fazer alterações dps. na vida real isso é difícil mas o ideal ja é ir acostumando */


        }
    }
}
