using System;                       // definir um tipo q armazena uma assinatura de uma função
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes 
{
    delegate double Operacao(double x, double y); // tipo: operação. A ideia é criar variariaveis e parametros de funcao q usam esse tipo

    class LambdasDelegate 
    {
        public static void Executar() {
            Operacao sum = (x, y) => x + y;
            Operacao sub = (x, y) => x - y;
            Operacao mult = (x, y) => x * y;
            Operacao div = (x, y) => x / y;

            Console.WriteLine(sum(3, 3));
            Console.WriteLine(sub(5, 2));
            Console.WriteLine(mult(12, 8));
            Console.WriteLine(div(49, 7));
        }
    }
}
