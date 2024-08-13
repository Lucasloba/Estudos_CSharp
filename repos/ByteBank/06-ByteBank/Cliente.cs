using System;                         // { get; set; } é uma manobra de facilitar a definição de um código
using System.Collections.Generic;     // tipo assim: tem um atributo x que vc que ele só seja acessado 
using System.Linq;                    // se ele respeitar Y e Z restrições. com get e set vc faz essa determinação 
using System.Text;                    // dentro do objeto que voce colocou o atributo (de modo encapsulado) 
using System.Threading.Tasks;         // desse jeito, fica mais facil e seguro de acessar esse atributo por "fora"
                                      // (em outras classes que o atributo seja referenciado)
namespace _06_ByteBank
{
    public class Cliente
    {
        private string _cpf;
        public string Nome { get; set; }

        public string CPF 
        {
            get
            {
                return _cpf;
            }
            set
            {
                // Escreva seu código de validação aqui
                _cpf = value;
            }
        }
        public string Profissao { get; set; }
    }
}
