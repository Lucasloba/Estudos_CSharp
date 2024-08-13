using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    class Pessoa 
    {
        public string Nome; // public == atributo vizível 
        public int Idade;   // tipo : string. Pascal Case (primeira letra maiúscula e sem espaços)

        public string Apresentar() 
        {
            return string.Format($"Olá! Me chamo {Nome} e tenho {Idade} anos.");
        }

        public void ApresentarNoConsole() 
        {
            Console.WriteLine(Apresentar());
        }
        public void Zerar() 
        {
            Nome = "";
            Idade = 0;
            if (Nome == null && Idade <= 0) ;
            Console.WriteLine("Os dados não estão preenchidos"); //pq o if n anulou o public void zerar ?
        }
    }
}
