using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_prt8_MNMListT
{
    public static class ListExtensoes
    {
        public static void AdicionarVarios<T>(this List<T> listaDeInteiros, params T[] itens)
        {
            foreach (T item in itens)
            {
                listaDeInteiros.Add(item);
            }
        }
    }
}
