using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDBV.Diretorias
{
    internal class Diretoria
    {
        public int IdadeDesbravador { get; set; }
        public void SerDiretoria()
        {
            if(IdadeDesbravador >= 16)
            {
                Console.WriteLine("Você faz parte da diretoria");
            }
            if(IdadeDesbravador < 16)
            {
                Console.WriteLine("Vc ainda é desbravador");
            }
        }
    }
}
