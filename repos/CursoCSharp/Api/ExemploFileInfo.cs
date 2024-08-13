using System;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace CursoCSharp.Api 
{
    class ExemploFileInfo 
    {
        public static void ExcluirSeExistir(params string[] caminhos) {
            foreach(var caminho in caminhos) {
                FileInfo arquivo = new FileInfo(caminho);

                if (arquivo.Exists) {
                    arquivo.Delete();
                }
            }
        }

        public static void Executar() {
            var caminhoOrigem = @"~/arq_origem.txt".ParseHome(); //a função de parse.home é tirar p "~" da sentença fazendo com que o nome do codigo seja executado do jeito certo
            var caminhoDestino = @"~/arq_destino.txt".ParseHome();
            var caminhoCopia = @"~/arq_copia.txt".ParseHome();

            ExcluirSeExistir(caminhoOrigem, caminhoDestino, caminhoCopia);

            using (StreamWriter sw = File.CreateText(caminhoOrigem)) {
                sw.WriteLine("Arquivo original");
            }

            FileInfo Origem = new FileInfo(caminhoOrigem);
            Console.WriteLine(Origem.Name);
            Console.WriteLine(Origem.IsReadOnly);
            Console.WriteLine(Origem.FullName);
            Console.WriteLine(Origem.Extension);
            Console.WriteLine(Origem.DirectoryName);

            Origem.CopyTo(caminhoCopia);
            Origem.MoveTo(caminhoDestino);
        }
    }
}
