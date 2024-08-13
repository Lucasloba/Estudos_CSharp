using ByteBank_MaoNaMassa_ConstrutoresEProtected.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_MaoNaMassa_ConstrutoresEProtected.Funcionarios
{
    class Diretor : Autenticavel

    {
        public Diretor(string cpf) : base(5000, cpf) 
        {
            Console.WriteLine("Construtor de DIRETOR");
        }

        public override void AumentoSalario()
        {
            Salario *= 1.15;
        }
    }
}
