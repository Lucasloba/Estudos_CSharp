using Newtonsoft.Json;
using System.Xml.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace TesteSerializar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dados meusDados = new Dados("manhã");
            meusDados.Nome = "Lucas Alves Matos";
            meusDados.idade = 18;
            meusDados.RA = 00349236;
            meusDados.Curso = "Ciências da Computação";

            if(meusDados.idade == 18)
            {
            // sintaxe e processo de serialização para .json
            string json = JsonConvert.SerializeObject(meusDados, Formatting.Indented);
            //ao adicionar o caminho, coloque o nome do arquivo q será criado dentro da 
            //pasta + ´.json´ .
            FileStream fs = new FileStream(@"C:\temp\export\meusDados.json", FileMode.Create);
            using (StreamWriter streamwriter = new StreamWriter(fs))
            {
                streamwriter.WriteLine(json);
            }
            Console.WriteLine(@"Arquivo salvo em C:\temp\export\ ");
            Console.ReadLine();
            }
            else
            {
                //sintaxe e processo de serialização para .xml (está com problemas)
                var contasXML = new XmlSerializer(typeof(List<Dados>));

                try
                {
                    FileStream fs = new FileStream(@"c:\temp\export\meusDados.xml", FileMode.Create);
                    using (StreamWriter streamwriter = new StreamWriter(fs))
                    {
                        contasXML.Serialize(streamwriter, meusDados);
                    }
                    Console.WriteLine(@"Arquivo salvo em c:\temp\export\");
                    Console.ReadKey();
                }
                catch (ArgumentException excecao)
                {
                    throw new ArgumentException(excecao.Message);
                    Console.ReadKey();
                }
                Console.WriteLine("´meusDados´ salvo em XML");
            }

        }
    }
}
