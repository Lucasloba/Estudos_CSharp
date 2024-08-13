using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaSimples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var valor = "123";
            var valor2 = true;
            var valor3 = DateTime.Now;

            //Console.WriteLine(valor);
            //Console.WriteLine(valor2);
            //Console.WriteLine(valor3);


            //pd converter nesses casos
            var v1 = Console.ReadLine();
            var v2 = Console.ReadLine();

            if(v1 == "1")
            {
                return;
            }

            string texto = "true";

            bool verConversao = bool.Parse(texto);

            Console.WriteLine(verConversao);





            //void ListaSimples()
            //{
            //    var list = new List<string>()
            //    {
            //        
            //    };
            //
            //    for (int i = 0; i < 5; i++) 
            //    {
            //
            //        Console.WriteLine("Fala seu nome");
            //        list.Add(list[1]);
            //    }
            //
            //     Console.WriteLine(list);
            //}
            //
            //ListaSimples();
        }
    }
}
