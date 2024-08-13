using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public abstract class Funcionario
    {
        public static int TotalDeFuncionarios { get; private set; }
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }


        public Funcionario(double salario, string cpf) // Construtor com campo estático definido por fora dele
        {
            CPF = cpf;
            Salario = salario;

            Console.WriteLine("Criando um FUNCIONÁRIO");
            TotalDeFuncionarios++;
                            // ++ ==
                            // += 1 ==
                            // TotalDeFuncionarios = TotalDeFuncionarios + 1
        }

        public abstract void AumentarSalario(); //assinatura 

        public abstract double GetBonificacao(); //assinatura

        //public abstract string NomeTeste();
    }
}
