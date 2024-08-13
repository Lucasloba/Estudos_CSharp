using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExComprarFrutaMaca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valMacas, valTot, qntdd;

            Console.WriteLine("Quantas maçãs vc quer? ");
            qntdd = Convert.ToDouble(Console.ReadLine());

            if(qntdd >= 12)
            {
                valMacas = 0.25;
            }
            else
            {
                valMacas = 0.3; 
            }

            valTot = qntdd * valMacas;

            Console.WriteLine("O valor total da compra é R$ " + valTot);
        }
    }
}
