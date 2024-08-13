using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento 
{
    public class FilhoReconhecido : Subcelebridade // recebeu os atributos por herança 
    {
        public new void MeusAcessos() {
            Console.WriteLine("FilhoReconhecido...");

            Console.WriteLine(InfoPublica); // acessível por ser publico 
            Console.WriteLine(CorDoOlho); // recebe por herança  
            Console.WriteLine(NumeroCelular); // acessível por estar dentro do mesmo projeto 
            Console.WriteLine(JeitoDeFalar); // acessível por herança ou projeto (é os dois casos)
            Console.WriteLine(SegredoFamilia); // acessível por herança mas tem q ta dentro do msm projeto
           // Console.WriteLine(UsaMuitoPhotoshop); [NÃO acessível pois é privado (só é acessível na classe)] 
        }
    }
}
