using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos 
{ 
    /// <summary>
    /// 
    /// </summary>
    class Comentarios 
    {
        /// <summary>
        /// Esse método finaliza o pedido! (exemplo de aviso desnecessário)
        /// </summary>
        public static void Executar() {
            // Cuidado com os comentários desnecessários
            Console.WriteLine("Código claro é sempre melhor");

            /* eu amo a 
             * rayssa (comentario de 2+
             */
            Console.WriteLine("O C# tem o XML Comments");
        }
    }
}
