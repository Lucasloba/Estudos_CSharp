using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ESTUDO_PROVA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("olá");

            MetodoTeste(27, "uuu");

            CtorTeste ctor = new CtorTeste("aaa", "comida");
            {
                ctor.Nome = "Lucas";
                ctor.Comida = "Batata";
            }

            var list = new List<string>();
            {
                list.Add("um");
                list.Add("dois");
                list.Add("tres");
                list.Add("quatro");
            }

            foreach (var i in list) 
            {
                if (list.Contains("quatro"))
                {
                    Console.WriteLine("ufa mano, vc chegou no quatro");
                }
                break;
            }

            string[] palavras = new string[2];
            {
                palavras[0] = "Andre";
                palavras[1] = "Luis";

            }
            
            */


            ProcessoSoma();
        }

        public static void ProcessoSoma()
        {
            Console.WriteLine("Poe um numero ai rapaiz");
            int a = Convert.ToInt32(Console.ReadLine());
            Thread.Sleep(1000);
            Console.WriteLine("dnv");
            int b = Convert.ToInt32(Console.ReadLine());
            int resoposta = a + b;
            Console.WriteLine(resoposta);
        }


        static void MetodoTeste(int aaa, string bbb)
        {
            Console.WriteLine(aaa + " somando-se " + bbb);
        }

        static void MetodoLista()
        {
            var list2 = new List<string>()
            {
                "ado",
                "ado2",
                "ado3"
            };
        }
    }
}
