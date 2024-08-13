using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AttributeBrowserAddin
{
    internal class Program
    {
        static void Main(int[] argumentos)
        {
            string[] a = {"a", "b", "c" };

            foreach (string name in a) 
            {
                Console.WriteLine(name);
            }
        }
    }
}
