using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamParaUmArquivo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var fs = new FileStream("c:/temp/nomes.txt", FileMode.Open))
            {
                var buffer = new byte[128]; // Buffer de 128 bytes
                var encoding = Encoding.UTF8;

                var bytesLidos = -1;

                var numeroCaracteres = new StreamReader(fs);

                ///<summary>
                /// as 3 linhas abaixo imprimem a quantidade de caracteres do arquivo
                /// agr eu percebi q é a coisa mais inútil do mundo pq o sistema operacional
                /// ja mostra o tamanho, n precisa de uma função p isso
                ///</summary>
                var num = numeroCaracteres.ReadToEnd();
                var algarismo = num.Length;
                Console.WriteLine(algarismo);


                /*
                while (bytesLidos != 0)
                {
                    bytesLidos = fs.Read(buffer, 0, 128);
                    var conteudo = encoding.GetString(buffer, 0, 128);
                    Console.Write(conteudo);
                }
                */
            }
        }
    }
}
