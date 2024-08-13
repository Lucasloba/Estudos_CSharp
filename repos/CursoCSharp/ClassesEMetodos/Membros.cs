using System;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos { // dentro do namespace pd ter varias classes
    class Membros 
    {
        public static void Executar() {
            Pessoa sicrano = new Pessoa(); //"pessoa()" construtor. "new pessoa()" novo objeto criado.
            sicrano.Nome = "Rayssa"; //notação ponto "." forma de acessar os membros da classe
            sicrano.Idade = 16;
                                   
            //Console.WriteLine($"{sicrano.Nome} tem {sicrano.Idade} anos.");

            sicrano.ApresentarNoConsole();
            sicrano.Zerar();
            sicrano.ApresentarNoConsole();

            var fulano = new Pessoa();
            fulano.Nome = "Lucas";
            fulano.Idade = 17;

            var apresentacaoDoFulano = fulano.Apresentar();

        }
    }
}
