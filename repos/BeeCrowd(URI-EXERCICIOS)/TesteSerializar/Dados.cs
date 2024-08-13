using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteSerializar
{ 
    public class Dados
    {
        public string Nome { get; set; }
        public int idade { get; set; }
        public int RA { get; set; }
        public string Curso { get; set; }
        public string TurnoDoCurso { get; set; }

        public Dados() { }

        public Dados(string turnoDoCurso)
        {
            TurnoDoCurso = turnoDoCurso;
        }

    }
}
