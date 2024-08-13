using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;                     
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos 
{
     public class Cliente {
        public string Nome;
        readonly DateTime Nascimento; //readonly = valor imutavel e vale na execução. Const = compilação e precisa colocar uma constante (x = n)
        const int x = 1; 

        public Cliente(string nome, DateTime nascimento) {
            Nome = nome;
            Nascimento = nascimento;
        }

        public string GetDataDeNascimento() {
            return String.Format("{0}/{1}/{2}", Nascimento.Day, Nascimento.Month, Nascimento.Year);
        }
    }    
    
                                                                                   //static e public pode mudar a ordem, n importa. menos void
    class Readonly {                                                               // public (acesso aos demais namespaces)
        public static void Executar () {                                           // static (nao precisa criar um objeto para executar)
            var novoCliente = new Cliente("Ana Silva", new DateTime(1987, 5, 22)); // void (função executar n retorna nada) 

            Console.WriteLine(novoCliente.Nome);
            Console.WriteLine(novoCliente.GetDataDeNascimento());

            //novoCliente.GetDataDeNascimento = new DataTime(2020, 10, 10);
        }
    }
}
