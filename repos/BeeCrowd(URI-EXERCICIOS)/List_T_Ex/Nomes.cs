using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_T_Ex
{
    internal class Nomes
    {
        public bool VerificaNomes(List<string> nomesDosEscolhidos, string escolhido)
        {
            return nomesDosEscolhidos.Contains(escolhido);
        }
    }
}
