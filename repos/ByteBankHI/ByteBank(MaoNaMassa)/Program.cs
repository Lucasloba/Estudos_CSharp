using ByteBank_MaoNaMassa_.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_MaoNaMassa_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario adalberto = new Funcionario();

            adalberto.Nome = "Adalbero";
            adalberto.CPF = "146.508.538-44";
            adalberto.Salario = 1737.45;

            gerenciador.Registrar(adalberto);

            Console.WriteLine("A bonificação de Adalberto é: " + adalberto.GetBonificacao());

            Diretor cleusa = new Diretor();

            cleusa.Nome = "Cleusa";
            cleusa.CPF = "963.567.247-45";
            cleusa.Salario = 6564.27;

            gerenciador.Registrar(cleusa);

            Console.WriteLine("A bonificação de Cleusa é: " + cleusa.GetBonificacao());

            Console.WriteLine("O total de bonificação é: " + gerenciador.GetBonificacao());

            Console.ReadLine();
        }
    }
}
