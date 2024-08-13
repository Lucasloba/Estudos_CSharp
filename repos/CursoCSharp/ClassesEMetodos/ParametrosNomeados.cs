using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    class ParametrosNomeados 
    {
        public static void Formatar(int dia, int mes, int ano) {
            Console.WriteLine("{0:D2}/{1:D2}/{2}", dia, mes, ano);  // "D2" = adiciona o zero se o valor so um
                                                                    // algarismo so, tipo q nem "mês". 
        }

        public static void Executar() {
            Formatar(mes: 7, dia: 18, ano: 2004); 
        }
    }
}
// note que a ordem de formatar e de formatar na execução está diferente, e isso n altera a compilação pq 
// os parametros estão nomeados... isso q é o legal de nomear.