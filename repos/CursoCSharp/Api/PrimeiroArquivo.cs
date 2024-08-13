using System;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace CursoCSharp.Api 
{
    public static class ExtensaoString {
        public static string ParseHome(this string path) {
            string home = (Environment.OSVersion.Platform == PlatformID.Unix ||
                Environment.OSVersion.Platform == PlatformID.MacOSX)
                ? Environment.GetEnvironmentVariable("HOME")
                : Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");
            return path.Replace("~", home);
        }
    }

    class PrimeiroArquivo 
    {
        public static void Executar() {
         /*  var x = "\tste\nestes\a.txt"; "@" serve para tornar a sentença somente visual em 100%, mesmo q haja atributos com funções textuais 
            Console.WriteLine(x); */
            var path = @"~/primeiro_arquivo.txt".ParseHome();

            if (!File.Exists(path)) {
                using (StreamWriter sw = File.CreateText(path)) { // cria um texto numa na pasta anterior a source 
                    sw.WriteLine("Esse é");
                    sw.WriteLine("o nosso");
                    sw.WriteLine("primeiro");
                    sw.WriteLine("arquivo!");
                }
            }
            using (StreamWriter sw = File.AppendText(path)) { // modifica/adiciona oq vc quiser de texto a essa pasta anterior criada
                sw.WriteLine("");
                sw.WriteLine("É possível");
                sw.WriteLine("adicionar");
                sw.WriteLine("mais texto!");
            }
        }
    }
}
