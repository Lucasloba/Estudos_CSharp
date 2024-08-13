using ByteBank.Funcionarios;
using ByteBankHI.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankHI.Funcionarios
{
    public class GerenteDeConta : FuncionarioAutenticavel
    {                                    //essa base é o construtor da classe base "Funcionario"
        public GerenteDeConta(string cpf) : base(4000, cpf)
        {
        }

        public override double GetBonificacao()
        {
            return Salario * 0.25;
        }

        public override void AumentarSalario()
        {
            Salario *= 0.05;
        }
    }
}
