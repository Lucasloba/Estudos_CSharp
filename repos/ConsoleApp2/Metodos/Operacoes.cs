using ConsoleApp2.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Metodos
{
    public class Operacoes
    {
        private List<Aluno> _alunosCadastrados;

        public Operacoes()
        {
            _alunosCadastrados = new List<Aluno>();
        }

        /// <summary>
        /// É necessário atrubuir uma entidade Aluno para a verificação no método
        /// </summary>
        /// <param name="aluno"></param>
        /// <returns></returns>
        public bool ExisteAluno(Aluno aluno)
        {
            return _alunosCadastrados.Any(x => x.CPF == aluno.CPF);
        }

        public string CadastrarAluno(Aluno aluno)
        {
            var resultado = ExisteAluno(aluno);

            if (resultado == true)
            {
                return $"O Aluno {aluno.Nome} já está cadastrado!";
            } 

            _alunosCadastrados.Add(aluno);
            return $"O aluno {aluno.Nome} foi includio com sucesso";
        }

        public void ListarAlunosCadastrados()
        {
            Console.WriteLine("");
            Console.WriteLine("Lista de Alunos Cadastrados!");
            foreach (var item in _alunosCadastrados)
            {
                Console.WriteLine($"Aluno: {item.Nome}, CPF: {item.CPF}, Turma: {item.Turma}");
            }
        }
    }
}
