using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TestesDoCursoDeStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string hahaha = "CavaloAlegre&Pulando%COMumBracoSo";
            string huhuhu = "COMumBracoSo";
            
            Console.WriteLine(hahaha.IndexOf('%'));
            Console.WriteLine(huhuhu.Length);
            Console.WriteLine(hahaha.Substring(hahaha.IndexOf('%')));
            Console.WriteLine(hahaha.Substring(hahaha.IndexOf('%') + huhuhu.Length - 1));

        }
    }
}
