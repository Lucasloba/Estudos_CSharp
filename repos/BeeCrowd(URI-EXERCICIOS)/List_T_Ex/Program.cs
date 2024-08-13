using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace List_T_Ex
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Exemplos basicos de como exibir uma lista e alguns metodos
            List<string> carros = new List<string>();
            string[] carros2 = new string[10];
    
            carros.Add("Golf");
            carros.Add("HRV");
            carros.Add("Focus");
            carros.Add("Argo");

            //carros2.Add("Fiesta");
            //carros2.Add("Onix");
            //carros2.Add("Toro");
            //carros2.Add("Fiorino");

            //carros.AddRange(carros2);

            //carros.Clear();

            if (carros.Contains("Gol"))
            {
                Console.WriteLine("Está na lsita");
            }
            else
            {
                Console.WriteLine("Não encontrado");
            }

            carros.CopyTo(carros2, 2);

            foreach (var percorre in carros)
            {
                Console.WriteLine("Carro {0}", percorre);
            }

            string percorreh = "HRV";
            int pos = 0;
            pos = carros.IndexOf(percorreh);
            Console.WriteLine("Carro {0} esta na posicao {1}", percorreh, pos);

            #region
            //Nomes nomes = new Nomes();

            //List<string> nomesDosEscolhidos = new List<string>()
            //{
            //    "Bruce Wayne",
            //    "Carlos Vilagran",
            //    "Richard Grayson",
            //    "Bob Kane",
            //    "Will Farrel",
            //    "Lois Lane",
            //    "General Welling",
            //    "Perla Letícia",
            //    "Uxas",
            //    "Diana Prince",
            //    "Elisabeth Romanova",
            //    "Anakin Wayne"
            //};

            //Console.WriteLine("digite o nome q c qr");
            //string escolhido = Convert.ToString(Console.ReadLine());

            //bool VerificaNomes(List<string> nomesDosEscolhido, string escolhidos)
            //{
            //    return nomesDosEscolhidos.Contains(escolhido);
            //}
            #endregion
            #region
            //List<string> L = new List<string>();

            //L.Add("Lucas");
            //L.Add("Bartolomeu");
            //L.Add("Josevaldo");

            //for (int i = 0; i < L.Count; i++)
            //{
            //    Console.WriteLine($"Nome {L}");
            //}
            #endregion
        }


    }
}

