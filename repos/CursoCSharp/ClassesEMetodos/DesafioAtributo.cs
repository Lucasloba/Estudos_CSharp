using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    class DesafioAtributo 
    {
        int a = 10;

        public static void Executar () {
            // Acessar variável "a" dentro do método Executar!
            // Console.WriteLine(a);

            DesafioAtributo desafio = new DesafioAtributo ();
            Console.WriteLine(desafio.a);
             
            // para acessar a instância "int a = 10" dentro do método executar, é preciso
            // criar um metodo dentro e instanciá-lo/anexá-lo a instancia q está de fora e 
            // colocar um contrutor "new DesadioAtributo" para fazer o link entre uma coisa e outra
        }
    }
}
