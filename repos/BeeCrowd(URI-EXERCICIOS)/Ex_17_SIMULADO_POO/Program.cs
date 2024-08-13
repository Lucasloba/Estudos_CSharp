using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ex_17_SIMULADO_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal pescocoLongo = new Animal();

            pescocoLongo.Nome = "Girafa";
            pescocoLongo.Alimento = "abóbora";

            int QuantidadeDeComida()
            {
                return 3;
            }

            Console.WriteLine(QuantidadeDeComida());

            pescocoLongo.NomeDaComida("vegetal Acacia");

            Console.WriteLine(pescocoLongo.NomeDaComida("vegetal Acacia"));
        }
    }
}
