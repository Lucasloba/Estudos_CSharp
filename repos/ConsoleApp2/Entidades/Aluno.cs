using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Entidades
{
    public class Aluno : Pessoa
    {
        public string Matricula { get; set; }
        public string Turma { get; set; }

        public Aluno(string nome, string cpf, string matricula, string turma ) : base(nome, cpf)
        {
            Matricula = matricula;
            Turma = turma;
        }
    }
}
