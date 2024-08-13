using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankHI.Sistemas
{
    public interface IAutenticavel
    {
        bool Autenticar(string senha);
    }
}
