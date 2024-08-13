using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class NotacaoPonto 
    { 
        public static void Executar() {
            var saudacao = "olá".ToUpper().Insert(3, " World")
                .Replace("World", "Mundo!");
            Console.WriteLine(saudacao);

            Console.WriteLine("Teste".Length);

            string valorImportante = null; //quando a var tá vazia, "null" dá erro. usando "?"(para valores não definidos), n dá erro
            Console.WriteLine(valorImportante?.Length);

        }
    }
}
