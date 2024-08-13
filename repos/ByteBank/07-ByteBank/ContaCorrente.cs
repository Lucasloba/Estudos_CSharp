// using _05_Bytebank - diretiva desnecessária após a locação do namespace


namespace _07_ByteBank
{
    public class ContaCorrente // Classe
    {
        public Cliente Titular { get; set; } // atributo + propriedade { get; set; }
             
       //static = propriedade que pertence a classe
        public static int TotalDeContasCriadas { get; private set; }
                                             //{ get; private set; } = pode ver mas n pode mudar.
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
                    _agencia = value;  // atributo + propriedade { get; set; } aberta.
                }
                else
                {
                    return;
                }
            }
        }
        public int Numero { get; set; }      // atributo + propriedade { get; set; }


        private double _saldo = 100;        // atributo

        public double Saldo             // Saldo é a propriedade do { get; set; } 
        {
            get                         // função/método de mostrar o valor
            {
                return _saldo;
            }
            set                         // função/método de dizer/definir o valor
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

        public ContaCorrente(int agencia, int numero) // Construtor 
        {
            Agencia = agencia;
            Numero = numero;

            TotalDeContasCriadas++;
        }

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




