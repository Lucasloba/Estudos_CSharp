using System;                          // tu vai usar { get; set; } qnd for somente um retorno direto de um valor
using System.Collections.Generic;      // e uma atribuição simples. Qnd tiver alguma restrição, aí ent vc abre o 
using System.Linq;                     // getter setter e define la oq ele precisa pra ser setado.
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank_MaoNaMassa_
{
    internal class ContaCorrente
    {
        private Cliente _titular;
        public Cliente Titular
        {
            get
            {
                return _titular;
            }
            set
            {
                _titular = value;
            }
        }
        public int Numero { get; set; }

        private int _agencia;
        public int Agencia
        {
            get
            {
                return _agencia;
            }
            set
            {
                _agencia = value;
            }
        }

        public double Saldo { get; set; }
    }
}
