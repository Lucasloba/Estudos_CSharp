using ByteBank.Funcionarios;            // metodos podem ter o msm nome desde que                                      
using System.Collections.Generic;       // seus argumentos sejam diferentes
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class GerenciadorBonificacao
    {
          //"private" p ngm mudar o _totalBonificacao fora dessa classe aqui
        private double _totalBonificacao;

        public void Registrar(Funcionario funcionario)
        {
          //_totalBonificacao = totalBonificacao + funcionario.GetBonificacao(); 
            _totalBonificacao += funcionario.GetBonificacao();
        }

        public double GetTotalBonificacao()
        {
            return _totalBonificacao;
        }

    }
}
