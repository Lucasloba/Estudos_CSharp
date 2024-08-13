using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    class Params {
        public static void Recepcionar(params string[] pessoas) { // "string[]" = paramentro que armazena parametros, é um array
            foreach (var pessoa in pessoas) {
                Console.WriteLine("Olá {0}", pessoa);
            }
        }


        public static void Executar() {
            Recepcionar("Lucas", "Rayssa", "Diamante", "Leo");
        }
    }
}
// usar o array "string[]" para agrupamento, dá pra anexar um comando repetitivo (dar "oi", etc)
// usando o foreach e dps cria outro metodo para compor a variável q, no caso, ficou: 
// "Recepcionar("Lucas", "Rayssa"... . Se n declarar nada, fica "null"  na compilação fica vazio 
