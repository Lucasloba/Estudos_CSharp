using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESTUDO_PROVA
{
    internal class CtorTeste
    {
        public string Nome { get; set; } 
        public string Comida { get; set; }
        public CtorTeste(string nome, string comida)
        {
            Nome = nome;
            Comida = comida;
            Console.WriteLine("Essa msg tem q aparecer");
        }
    }
}
