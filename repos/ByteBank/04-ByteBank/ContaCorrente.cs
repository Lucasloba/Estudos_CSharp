

public class ContaCorrente              // Classe
{
    public string titular;              // atributo
    public int agencia;                 // atributo
    public int numero;                  // atributo
    public double saldo = 100;          // atributo

    public bool Sacar(double valor)     // Função
    {
        if(this.saldo < valor)          // Condição
        {
            return false;
        }
       
        this.saldo -= valor;
        return true;
        
    } 

    public void Depositar(double valor)  // Função ou método
    {
        this.saldo += valor;
    }

    public bool Transferir(double valor, ContaCorrente contaDestino)
    {
        if (this.saldo < valor)
        {
            return false;
        }
        
        this.saldo -= valor;
        contaDestino.Depositar(valor);
        return true;

    }

}




