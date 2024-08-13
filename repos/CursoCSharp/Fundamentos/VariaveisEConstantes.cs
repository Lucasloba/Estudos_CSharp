using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos 
{
    internal class VariaveisEConstantes 
    {
        public static void Executar() {
            // area da circunferencia
            double raio = 4.5;
            const double PI = 3.14; // "const", ent o valor de PI n pode ser alterado

            raio = 5.5;
            // PI = 3.1415 (se n fosse um "//" (comentário), daria erro

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Área é " + area + 1000);

            // Tipos internos 

            bool estachovendo = true; // verdadeiro ou falso (boleano) 
            Console.WriteLine("Esta chovendo" + estachovendo);

            byte idade = 45; // byte = apenas um único byte, ou seja, 8bits (0 até 256 só positivos)
            Console.WriteLine("Idade" + idade);

            sbyte saldoDeGols = sbyte.MinValue; //(-128 até +127) {sbyte conta sinal!!!}
            Console.WriteLine("Saldo de Gols " + saldoDeGols);
            short salario = short.MaxValue; // short tem 2bytes (maior q +32_000)
            Console.WriteLine("Salário " + salario);

            int menorValorInt = int.MinValue; // Mais usados dos inteiros! 4bytes (-2 . 10^9)
            Console.WriteLine("Menor int " + menorValorInt);

            uint populacaoBrasileira = 207_600_000; // interio sem sinal (só positivos)
            Console.WriteLine("População Brasileira " + populacaoBrasileira);

            long menorValorLong = long.MinValue; // 8 bytes (valor bem maior que 2 . 10^9)
            Console.WriteLine("Menor long " + menorValorLong);

            ulong populacaoMundial = 7_600_000; // ("_" nos algarismo é so uma questao de organizção e "ulong" = long sem sinal)
            Console.WriteLine("População Mundial " + populacaoMundial);

            float precoComputador = 1299.99F; // (pode ser "F" ou "f" para que seja considerado um float)
            Console.WriteLine("Preço Computador " + precoComputador);

            double valorDeMercadoDaApple = 1_000_000_000_000; // Mais usado dos reais
            Console.WriteLine("Valor Apple " + valorDeMercadoDaApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue; // (para valores astronômico) 
            Console.WriteLine("Distância entre Estrelas " + distanciaEntreEstrelas);

            char letra = 'z'; // (quando for uma letra só, e usa-se aspas simples)
            Console.WriteLine("Letra " + letra);

            string texto = "o lucas vai ser um excelente programador"; // string: (literalmente qlqr texto, smp com aspas duplas)
            Console.WriteLine(texto);




        
        }
    }
}
