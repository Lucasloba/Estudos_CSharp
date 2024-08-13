using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;

namespace EstruturaEModelagemDeDados
{
    public class Program 
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(DobroNumero(5));
            Thread.Sleep(3000);
            Console.WriteLine(AreaCiculo(15));

            Campo campo = new Campo();
            campo.MetodoData();
            Console.WriteLine(campo);
        }


        public static int DobroNumero(int x)
        {
            return x * 2;
        }

        public static double AreaCiculo(double r)
        {
            double area = 3.145 * Math.Pow(r,2);
            return area;
        }
    }
}
