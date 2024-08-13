using System;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace CursoCSharp.Api 
{
    class Diretorios
    {
        public static void Executar() {
            var novoDir = @"~/PastaCSharp".ParseHome();
            var novoDirDestino = @"~/PastaCSharpDEstino".ParseHome();
            var dirProjeto = @"~/source/repos/CursoCSharp".ParseHome();

            if (Directory.Exists(novoDir)) {
                Directory.Delete(novoDir, true);
            }

            if (Directory.Exists(novoDirDestino)) {
                Directory.Delete(novoDirDestino, true);
            }

            Directory.CreateDirectory(novoDir);
            Console.WriteLine(Directory.GetCreationTime(novoDir));

            Console.WriteLine("== Pastas ==========");
            var pastas = Directory.GetDirectories(dirProjeto); // faz a lista das pastas 
            foreach (var pasta in pastas) {
                Console.WriteLine(pasta);
            }

            Console.WriteLine("\n\n== Arquivos =============");
            var arquivos = Directory.GetFiles(dirProjeto);     // faz a lista dos caminhos das pastas 
            foreach (var arquivo in arquivos) {
                Console.WriteLine(arquivo);
            }

            Console.WriteLine("n\n== Raiz ===============");
            Console.WriteLine(Directory.GetDirectoryRoot(novoDir));

            Directory.Move(novoDir, novoDirDestino);
        }
    }
}
