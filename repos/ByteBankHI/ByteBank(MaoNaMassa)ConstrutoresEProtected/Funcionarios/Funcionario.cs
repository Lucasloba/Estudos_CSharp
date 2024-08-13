using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_MaoNaMassa_ConstrutoresEProtected.Funcionarios
{
    public abstract class Funcionario
    {
        public double Salario { get; protected set; }
        public string CPF { get; private set; }
        public static int TotalDeFuncionatios { get; private set; }
        public string Nome { get; set; }

        public Funcionario(double salario, string cpf)
        {
            TotalDeFuncionatios++;
            Console.WriteLine("Construtor de FUNCIONARIO");
            CPF = cpf;
            Salario = salario;
        }

        public abstract void AumentoSalario();
        //{
        //    Salario *= 1.1;
        //}
    }
}
