using ByteBank_MaoNaMassa_ConstrutoresEProtected.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ByteBank_MaoNaMassa_ConstrutoresEProtected
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario bananao = new Diretor("463.864.578-35");
            
            

            Console.WriteLine(bananao.Salario);
            Console.ReadLine();

        }
    }
}
