using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto 
{
    class Program
    {
        static void Main(string[] args) 
        {
            string texto = "Hello World. My first project in C#";
            decimal numeroDecimal = 10; // em decimal usa-se o "M" para rodar, na compição "m" n aparece
            int numeroInteiro = 15;
            double numeroDouble = 20;

            string[] arrayString = {"Paulo", "Bruna", "André", "Priscila"};
            decimal[] arrayDecimal;
            int[] arrayInteiro;
            double[] arrayDouble;

            List<decimal> listaDecimal = new List<decimal> { 0,1,2,3,4,5};

          /*for(int x = 0; x<listaDecimal.Count; x++) 
            {
                Console.WriteLine(String.Format("Número: {0}", listaDecimal[x]));
                Console.WriteLine("Número" + listaDecimal[x]);
            } */

            foreach(decimal numero in listaDecimal)
            {
                Console.WriteLine(String.Format("Número: {0}", numero)); // duas formas de fazer a lista
                Console.WriteLine("Número: " + numero);
            }






            // ===============================================================================================================================================================================

            /*for(int x=0; x<arrayString.Length; x++) 
            {
                Console.WriteLine("Primeiro Nome:" + arrayString[x]);
                Console.WriteLine(String.Format("Primeiro Nome: {0} {1} {2}", arrayString[x], arrayString[x], arrayString[x]));
            } */

            /*foreach(String nome in arrayString) 
            {
                Console.WriteLine("Primeiro Nome:" + nome);
                Console.WriteLine(String.Format("Primeiro Nome: {0}", nome));
            }*?


            /*if (numeroDecimal == 10)
            {
                Console.WriteLine("Número == a 10.");
            }
            else 
            {
                Console.WriteLine("Número != de 10.");   
            }

            if (numeroDouble >= 20) 
            {
                Console.WriteLine("Número maior ou igual a 20.");
            }
            else 
            {
                Console.WriteLine("Número diferente de maior ou igual a 20.");
            } */

            Console.WriteLine(texto);
            Console.WriteLine("Hello World. My first project in C#");
            Console.WriteLine("Press 'Enter' for exit.");
            while(Console.ReadKey().Key != ConsoleKey.Enter) { } 
        }
    }
}
