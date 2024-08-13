using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Profissao { get; set; }

        public override bool Equals(object obj)
        {
          //Cliente outroCliente = (Cliente)obj;
          // as retorna null qnd a conversao n é verdadeira
            Cliente outroCliente = obj as Cliente;

            if(outroCliente == null)
            {
                return false;
            }


            return CPF == outroCliente.CPF;
                 
        }
    }
}
