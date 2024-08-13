using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento 
{
    public class AmigoProximo 
    {
        public readonly Subcelebridade amiga = new Subcelebridade(); //relação de composição

        public void MeusAcessos() {
            Console.WriteLine("AmigoProximo...");

            Console.WriteLine(amiga.InfoPublica); 
            // Console.WriteLine(amiga.CorDoOlho); [n acessível por ser protected q so é transmitido por herança mesmo q seja class proxima]
            Console.WriteLine(amiga.NumeroCelular);  
            Console.WriteLine(amiga.JeitoDeFalar);
            // Console.WriteLine(amiga.SegredoFamilia); [n acessível pois n é transmitido por herança]
            // Console.WriteLine(amiga.UsaMuitoPhotoshop); [n acessível pq so classe tem acesso {private}]
        }
    }
}
