using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_17_SIMULADO_POO
{
    public class Animal
    {
        public string Nome { get; set; }

        public string Alimento { get; set; }

        public string NomeDaComida(string Alimento)
        {
            return Alimento;
        }
    }
}
