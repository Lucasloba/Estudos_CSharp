using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank_MaoNaMassa_
{
    internal class ContaCorrente
    {
        public int _agencia;
        public int Agencia
        {
            get
            {
                return _agencia;
            }
            set
            {
                if (_agencia <= 0)
                {
                    _agencia = value;  
                }
                else
                {
                    return;
                }
            }
        }

        public int Numero { get; set; }
        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;

            TotalDeContasCriadas++;
        }
        public static int TotalDeContasCriadas { get; private set; }
        
    }
}
