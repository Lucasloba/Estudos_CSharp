using ConsoleApp2.Entidades;
using ConsoleApp2.Metodos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var alu1 = new Aluno("Pedro", "111", "11", "Turma A");
            var alu2 = new Aluno("Marcia", "2222", "22", "Turma B");
            var alu3 = new Aluno("Antonio", "3333", "33", "Turma A");
            var alu4 = new Aluno("Jorge", "4444", "44", "Turma D");
            var alu5 = new Aluno("Inácio", "5555", "55", "Turma A");
            var alu6 = new Aluno("Inácio", "5555", "55", "Turma A");

            Operacoes operacaoum = new Operacoes();

            for (int i = 0; i < 7; i++)
            {
                var resultado = "";
                if (i == 1) { resultado = operacaoum.CadastrarAluno(alu1); }
                if (i == 2) { resultado = operacaoum.CadastrarAluno(alu2); }
                if (i == 3) { resultado = operacaoum.CadastrarAluno(alu3); }
                if (i == 4) { resultado = operacaoum.CadastrarAluno(alu4); }
                if (i == 5) { resultado = operacaoum.CadastrarAluno(alu5); }
                if (i == 6) { resultado = operacaoum.CadastrarAluno(alu6); }

                Console.WriteLine(resultado);
            }

            operacaoum.ListarAlunosCadastrados();

        }
    }
}
