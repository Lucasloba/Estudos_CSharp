using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDBV
{
    public class Desbravador : ClassesRegAndAvan
    {
        public int Idade { get; set; }
        public string Nome { get; set; }
        public string Sexo { get; set; } //fzr if para sexo?

        public Desbravador()
        {

            Console.WriteLine("Insira sua idade : ");
            int Idade = int.Parse(Console.ReadLine());

            if (Idade >= 16)
            {
                Console.WriteLine("Vc é da diretoria                         <coitado>");

            }
            if (Idade <= 16)
            {
               Console.WriteLine("Vc é desbravador                          <sortudo>");
            }

            Console.WriteLine("Insira seu sexo : 'm' para masculino e 'f' para feminino ");
            string Sexo = Console.ReadLine();
            if (Sexo == "m")
            {
                Console.WriteLine("Tu é man, vai p unidade raposOs");
            }
            if (Sexo == "f")
            {
                Console.WriteLine("Tu é girl, vai p unidade raposAs");
            }

        }

    }
}
