using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos {
    internal class FormatandoNumero
    {
        public static void Executar() {
            double valor = 15.175;

            //"ToString" transformar um valor numérico numa string

            Console.WriteLine(valor.ToString("F1")); //"F1" = apenas uma casa decimal 15.175 ~ 15,2
            Console.WriteLine(valor.ToString("C")); //"C" = currency (uma moeda) 15.175 = R$ 15,18 (R$ pq é a configuração)
            Console.WriteLine(valor.ToString("P")); //"P" = percentual (%) 15.175 = 1.517,05%
            Console.WriteLine(valor.ToString("#.##")); // pode usar quantos "#" quiser mas vai parar na qtdd do num original

            CultureInfo cultura = new CultureInfo("pt-BR");
            Console.WriteLine(valor.ToString("C3", cultura)); //"C0" indica nhma csa deciaml. C2, duas e ass p/diante

            int inteiro = 0000000256;
            Console.WriteLine(inteiro.ToString("D10")); //"D" qnd precisa considerar todos os zeros (até os à esquerda)



        }
    }
}
