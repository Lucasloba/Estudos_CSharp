using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ArraysTeste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] batataas = new double[] { 3, 5, 9, 17 };

            Console.WriteLine(MediaDaAmostra(batataas));

            double MediaDaAmostra(double[] amostra)
            {
                double media = 0;
                double acumulador = 0;

                if ((amostra == null) || (amostra.Length == 0))
                {
                    Console.WriteLine("Amostra de dados nula ou vazia.");
                    return 0;
                }
                else
                {
                    for (int i = 0; i < amostra.Length; i++)
                    {
                        acumulador += amostra[i];
                    }
                    media = acumulador / amostra.Length;
                }

                return media;
            }

              //------------------------------------------------------------------------------//
            // | Propriedade / Método|                       Descrição                         |
            // |---------------------|---------------------------------------------------------|
            // | GetValue            | retorna o conteúdo/valor de um elemento pelo índice.    |
            // | GetLength	         | retorna o números de elementos do array.                |
            // | Rank		         | retorna o número de dimensões de um array.              |
            // | CopyTo		         | cria uma cópia de todos os valores de um array.         |
            // | Sort		         | ordena os valores de um array de forma ascendente.      |
            // | Reverse		     | inverte a ordem de elementos de um array.               |
            // | Clone		         | cria uma cópia do array.                                |
            // | Length		         | retorna o número de elementos de um array.              |
            // | IndexOf		     | encontra a primeira ocorrência de um elemento no array. |
            // | LastIndexOf	     | encontra a última ocorrência de um elemento no array.   |
            // | Clear		         | limpa todas as posições de um array.                    |
            // | Exists		         | verifica se existe ou não um elemento no array.         |
              //------------------------------------------------------------------------------//

        }
    }
}


