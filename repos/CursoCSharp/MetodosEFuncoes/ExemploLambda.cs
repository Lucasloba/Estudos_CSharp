using System;                       // operador de declaração lambda "=>" 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes 
{
    class ExemploLambda 
    {
        public static void Executar() {
            Action algoNoConsole = () => { // action n tem retorno 
                Console.WriteLine("Lambda com C#!" );
            };

            algoNoConsole();

            Func<int> jogarDado = () => {
                Random random = new Random();
                return random.Next(1, 7);
            };

            Console.WriteLine(jogarDado());

            Func<int, string> conversorHex = numero => numero.ToString("X"); // define a func em numero (int) e retorna em string (hexadecimal)
            Console.WriteLine(conversorHex(1234));

            Func<int, int, int, string> formatarData = (dia, mes, ano) => // com arrow (=>), implicitamente há um return
                String.Format("{0:D2}/{1:D2}/{2:D4}", dia, mes, ano);
            Console.WriteLine(formatarData(1, 1, 2019));
        }
    }
}
