using ByteBankHI.Funcionarios;
using ByteBankHI.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    {
        // herança do Construtor base == public Funcionario(string cpf)
        public Diretor(string cpf) : base(5000, cpf)
        {
            Console.WriteLine("Criando um DIRETOR");
        }
   
        public override double GetBonificacao() 
        {
            return Salario * 0.5;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }
    }
}
