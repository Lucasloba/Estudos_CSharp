using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos 
{
   class Carro {
        public string Modelo;
        public string Fabricante;
        public int Ano;

        public Carro(string modelo, string fabricante, int ano) {
            Modelo = modelo;
            Fabricante = fabricante;
            Ano = ano;
        }
        public Carro() {

        }
    } 
   
    internal class Construtores 
    {
        public static void Executar() {
            var carro1 = new Carro();  //"new Carro" - construtor: tem o msm nome q a class dele atribuido "carro"
            carro1.Fabricante = "BMW"; // qnd vc cria sem criar, ele se dá como construtor padrão e n recebe parametro (null)
            carro1.Modelo = "325i";
            carro1.Ano = 2017;
            Console.WriteLine($"{carro1.Fabricante} modelo {carro1.Modelo} do ano de {carro1.Ano}");

            var carro2 = new Carro("Hyndai", "Honda", 2009);
            Console.WriteLine(
                $"{carro2.Fabricante} Modelo {carro2.Modelo} do ano de {carro2.Ano}");

            var carro3 = new Carro() { // outra forma de fzr
                Fabricante = "Ferrari",
                Modelo = "carro daora",
                Ano = 2022
            };
            Console.WriteLine(
                $"{carro3.Fabricante} {carro3.Modelo} {carro3.Ano}");
        }
    }
}
