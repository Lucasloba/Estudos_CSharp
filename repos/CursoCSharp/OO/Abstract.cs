using System;                          //classe abstrata pode ou n ter metodos concretos.
using System.Collections.Generic;      //metodos abstratos sao metodos sem corpo 
using System.Linq;                     // classe abstrata: classe inacabada q serve para ser herdada por outras classes contretas.
using System.Text;                     // estas precisaram ter seus metodos instanciados com "abstract"
using System.Threading.Tasks;          // foi planejada pra ser herdada e ter heranças como classes filhas

namespace CursoCSharp.OO 
{
    public abstract class Celular { // abstract n da p instanciar
        public abstract string Assistente(); 
       
    
        public string Tocar() {
            return "Trin trim trim...";
        }
    }

    public class Samsung : Celular {
        public override string Assistente() {
            return "Ola! Meu nome é Bixby!";
        }
    }

    public class IPhone : Celular {
        public override string Assistente() {
            return "Ola! Meu nome é Siri!";
        }
    }

    class Abstract {
        public static void Executar() {
            // Celular c = new Celular(); não pode instanciar, pois tem q ser classe concreta
            var celulares = new List<Celular> {
                new IPhone(),
                new Samsung()
            };

            foreach (var celular in celulares) {
                Console.WriteLine(celular.Assistente());
            }
        }
    }
}
