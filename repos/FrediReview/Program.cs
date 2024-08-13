using System;
using System.Security.Cryptography;
using System.Xml;

class Program
{
    static void Main()
    {
        string[] nomes = {"pelo", "maquina de lavar"};

        foreach (string s in nomes) { Console.WriteLine(s); }

        for (int i = 0; i < nomes.Length; i++) { Console.WriteLine(nomes[i]); }

        // Tratamento de Strings
        #region
         string name = "   _ No berto de Castro _   ";
        // Console.WriteLine(name.Length);
        // Console.WriteLine(name.EndsWith("a"));
        // Console.WriteLine(name.StartsWith("L"));
        // Console.WriteLine(name.Split("c"));
         Console.WriteLine(name.Trim());
        // Console.WriteLine(name.Contains('a'));
        // Console.WriteLine(name.IndexOf("c"));
        // Console.WriteLine(name.ToUpper());
        // Console.WriteLine(name.ToLower());
        // 
        // string aula = "aaaa";
        // Console.WriteLine(string.IsNullOrEmpty(aula));
        // Console.WriteLine(string.IsNullOrWhiteSpace(aula));
        // Console.WriteLine(string.Join(' ',aula, name));
        // 
        // string[] numeros = { "1", "2", "3" };
        // Console.WriteLine(string.Join(',', numeros));
        // 
        // //Uso direto dos métodos
        // Console.WriteLine("Jonas".Length);
        // 
        // //TryParse retorna bool (dps da análise)
        // int a = 10;
        // bool tente = int.TryParse("50",out a);
        // Console.WriteLine(tente);
        // Console.WriteLine(a);
        // 
        // //Parse retorna int (dps da conversão)
        // string dia = "11";
        // int day = int.Parse(dia);
        // Console.WriteLine("Hoje é dia " + day);
        #endregion

        // Condicionais e Loops
        #region
        //       string[] names = { "Lucas", "Rayssa", "Jonas" };
        //     
        //       //membros da classe string
        //       if (string.Equals(names[0],"lucas",StringComparison.OrdinalIgnoreCase)) 
        //       {
        //           Console.WriteLine("é igual");
        //       }
        //       else
        //       {
        //           Console.WriteLine("não é igual"); 
        //       }
        //     
        //       Console.WriteLine(names[0] + " com índice");
        //       Console.WriteLine(names[1] + " com índice");
        //     
        //       for (int i = 0; i < names.Length; i++) 
        //       {
        //           Console.WriteLine(names[i]);
        //           Console.WriteLine("Com for");
        //           Console.WriteLine(" ");
        //       }
        //     
        //       foreach (string name in names) 
        //       {
        //           Console.WriteLine(name);
        //           Console.WriteLine("Com foreach");
        //           Console.WriteLine(" ");
        //       }
        //     
        //       int a = 0;
        //       while (a <= 1) 
        //       {
        //           Console.WriteLine("uga uga");
        //           a++;
        //           Console.WriteLine("Com while");
        //       }
        #endregion
    }
}

//Principios
#region
//          Console.Write("Diga seu nome: ");
//          string name = Console.ReadLine();
//          Console.WriteLine($"Olá {name}! We´re here for U");
//          Console.Write("Digite o ano em que vc nasceu: ");
//          int year = int.Parse(Console.ReadLine());
//          int age = 2023 - year;
//          Console.WriteLine($"A sua idade é {age} anos!");
//          
//          if (age >= 18)
//          {
//              Console.WriteLine($"Parabéns,{name} vc é maior de idade");
//          }
//          else 
//          {
//              Console.WriteLine($"Lamento,{name} vc ainda é menor de idade");
//          }
//          
//          
//          /*string */
//          /*float  */
//          /*byte   */
//          /*decimal*/
//          /*double */
//          /*bool   */
//          /*char   */
//          /*int    */
//          /*long   */
//          
//          Console.WindowTop = 0;
//          
//          //Console.BackgroundColor
#endregion





