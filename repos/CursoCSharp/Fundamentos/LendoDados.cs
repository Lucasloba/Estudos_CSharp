using System;
using System.Globalization; // usando o globalization, pode usar "." ou "," no salário q ele vai contar 

namespace CursoCSharp.Fundamentos {
    internal class LendoDados 
    {
        public static void Executar() {
            Console.Write("Qual é o seu nome? ");
            string nome = Console.ReadLine();

            Console.Write("Qual é a sua idade? ");
            int idade = int.Parse(Console.ReadLine()); // "1" -} 1 (parsse/transforma); "opa" -} "1" (nesse caso dá problema.

            Console.WriteLine("Qual é o seu salário? ");
            double salario = double.Parse(Console.ReadLine(),
                CultureInfo.InvariantCulture);

           // Console.WriteLine("O {0} {1} R${2}.", nome, idade, salario); (uma outra opção...)
            Console.WriteLine($"{nome} {idade} R${salario}");

        }
    }
}
