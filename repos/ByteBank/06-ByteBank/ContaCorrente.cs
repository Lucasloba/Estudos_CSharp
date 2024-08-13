// using _05_Bytebank - diretiva desnecessária após a locação do namespace


namespace _06_ByteBank
{
    public class ContaCorrente              // Classe
    {
        public Cliente Titular { get; set; } // atributo + propriedade { get; set; }
        public int agencia { get; set; }     // atributo + propriedade { get; set; }
        public int numero { get; set; }      // atributo + propriedade { get; set; }


        private double _saldo = 100;        // atributo

        public double Saldo             // Saldo é a propriedade do { get; set; } 
        {
            get                         // função/método de pegar o valor
            {
                return _saldo;
            }
            set                         // função/método de colocar o valor
            {
                if (value < 0)
                {
                    return;
                }

                //saldo do objeto = value é o argumento do método 
                _saldo = value;
            }
        }

        /*
         -------- ESTRUTURA { get; set; } ----------
        public void SetSaldo(double saldo)  // Função de Definir
        {
            if (saldo < 0)
            {
                return;
            }
        
            //saldo do objeto = saldo do argumento
            this.saldo = saldo;
        }

        public double GetSaldo()         // Função de Obter
        {
            return saldo;
        }

        */

        public bool Sacar(double valor)     // Função
        {
            if (_saldo < valor)          // Condição
            {
                return false;
            }

            _saldo -= valor;
            return true;

        }

        public void Depositar(double valor)  // Função ou método
        {
            _saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
            {
                return false;
            }

            _saldo -= valor;
            contaDestino.Depositar(valor);
            return true;

        }

    }

}




