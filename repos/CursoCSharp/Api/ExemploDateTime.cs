using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Api 
{
    class ExemploDateTime 
    {
        public static void Executar() {
            var dateTime = new DateTime(year: 2030, month: 2, day: 6); // criar a exibição do dia

            Console.WriteLine(dateTime.Day);
            Console.WriteLine(dateTime.Month);
            Console.WriteLine(dateTime.Year);

            // Sem horas
            var hoje = DateTime.Today; // criar a exibição de hoje 
            Console.WriteLine(hoje);

            // Com horas
            var diaAtual = DateTime.Now; // dia de hoje e a hora obviamente
            Console.WriteLine(diaAtual);
            Console.WriteLine("Hora: " + diaAtual.Hour);
            Console.WriteLine("Minutes: " + diaAtual.Minute);
         // Console.WriteLine("Seconds: " + diaAtual.seconds); se tivesse parametro para segundos, tbm daria pra colocar na compilação

            var amanha = diaAtual.AddDays(1); // mais um dia
            Console.WriteLine(amanha);
             
            var ontem = diaAtual.AddDays(-1); // menos um dia 
            Console.WriteLine(ontem);

            var anteontem = diaAtual.AddDays(-2); /* ou diaAtual.AddDays(-2) */ //menos dois dias 
            Console.WriteLine(anteontem);

            var depoisdeamanha = diaAtual.AddDays(+2); // mais dois dias 
            Console.WriteLine(depoisdeamanha); 

            Console.WriteLine(diaAtual.ToString("dd"));
            Console.WriteLine(diaAtual.ToString("d"));
            Console.WriteLine(diaAtual.ToString("D"));
            Console.WriteLine(diaAtual.ToString("g"));
            Console.WriteLine(diaAtual.ToString("G"));
            Console.WriteLine(diaAtual.ToString("dd^MM^yyyy HH:mm"));

        }
    }
}
