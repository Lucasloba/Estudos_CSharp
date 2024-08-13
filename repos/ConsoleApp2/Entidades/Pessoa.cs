using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Entidades
{
    public class Pessoa
    {
        public Pessoa(string nome, string cpf)
        {
            Nome = nome;
            CPF = cpf;
        }

        public string Nome { get; set; }
        public string CPF { get; set; }
       
    }
}
