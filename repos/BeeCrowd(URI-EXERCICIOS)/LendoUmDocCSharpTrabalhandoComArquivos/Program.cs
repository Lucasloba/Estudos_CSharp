using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LendoUmDocCSharpTrabalhandoComArquivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fs = new FileStream("c:/temp/teste.txt", FileMode.Open);

            var buffer = new byte[1024];
            var encoding = Encoding.ASCII;

            var bytesLidos = fs.Read(buffer, 0, 1024);
            var conteudoArquivo = encoding.GetString(buffer, 0, bytesLidos);

            Console.Write(conteudoArquivo);
        }
    }
}
