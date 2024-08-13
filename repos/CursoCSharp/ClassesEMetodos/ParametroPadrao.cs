using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos 
{
    class ParametroPadrao 
    {
        public static int Somar(int a = 1, int b = 1) { // vc pode colocar valores padrão nos parametros
            return a + b;
        }

        public static void Executar () {
            Console.WriteLine(Somar(10, 23));
            Console.WriteLine(Somar(51));
            Console.WriteLine(Somar());
            Console.WriteLine(Somar(b: 7)); // 1 + 7 
        }
    }
}
