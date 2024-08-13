using System;
using System.Linq;
using System.Threading.Tasks;
using Encapsulamento;

namespace CursoCSharp.OO {
    public class FilhoNaoReconhecido : Subcelebridade {
        public new void MeusAcessos() {
            Console.WriteLine("FilhoNaoReconhecido...");

            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho); // recebido pq é por herança, estando ou n no msm projeto 
            // Console.WriteLine(NumeroCelular); [n acessa pq é interal, tem q ta no msm projeto
            Console.WriteLine(JeitoDeFalar);
            // Console.WriteLine(SegredoFamilia); [n acessa pq é transmitido por herança SOMENTE dentro do projeto]
            //Console.WriteLine(UsaMuitoPhotoshop); [n; são projetos diferentes]
        }
    }

    public class AmigoDistante {
        public readonly Subcelebridade amiga = new Subcelebridade(); // acesso por instância

        public void MeusAcessos() {
            Console.WriteLine("AmigoDistante...");

            Console.WriteLine(amiga.InfoPublica); // so tem info publica de acessível pois é do tipo "public"  
            /* Console.WriteLine(amiga.CorDoOlho);
            Console.WriteLine(amiga.NumeroCelular);
            Console.WriteLine(amiga.JeitoDeFalar);
            Console.WriteLine(amiga.SegredoFamilia);
            Console.WriteLine(amiga.UsaMuitoPhotoshop); */
        }
    }

    class Encapsulamento {
        public static void Executar() {
            Subcelebridade sub = new Subcelebridade();
            sub.MeusAcessos();

            new FilhoReconhecido().MeusAcessos();
            new AmigoProximo().MeusAcessos();

            new FilhoNaoReconhecido().MeusAcessos();
            new AmigoDistante().MeusAcessos();
        }
    }
}
