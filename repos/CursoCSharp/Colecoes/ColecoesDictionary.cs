using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes 
{
    class ColecoesDictionary 
    {
        public static void Executar() {
            var filmes = new Dictionary<int, string>();

            filmes.Add(2000, "Gladiador");      //"add" adiciona elementos
            filmes.Add(2002, "Homem-Aranha");
            filmes.Add(2004, "Os Incríveis");
            filmes.Add(2006, "O Grande Truque");

            if (filmes.ContainsKey(2004)) {
                Console.WriteLine("2004: " + filmes[2004]);                       //duas maneiras de ver se tem some movie in list 
                Console.WriteLine("2004: " + filmes.GetValueOrDefault(2004));
            }

            Console.WriteLine(filmes.ContainsValue("Amnésia")); // verifica se algum movie está contido na lista 

            Console.WriteLine($"Removeu? {filmes.Remove(2004)}"); // remove a chave instanciada nas listas subsequentes

            filmes.TryGetValue(2016, out string filme2006); // "trygetvalue" tenta pegar um valor a partir da cahve
            Console.WriteLine($"Filme {filme2006}!");

            foreach (var chave in filmes.Keys) { // faz uma lista dos anos
                Console.WriteLine(chave);
            }

            foreach (var valor in filmes.Values) { // faz uma lista dos nomes dos filmes
                Console.WriteLine(valor);
            }

            foreach (KeyValuePair<int, string> filme in filmes) {
                Console.WriteLine($"{filme.Value} é de {filme.Key}."); // lista os filmes por nome e ano de lançamento
            }

            foreach (var filme in filmes) {
                Console.WriteLine($"{filme.Value} é de {filme.Key}."); // outro jeito de listar os filmes por nome e ano de lançamento
            }
        }
    }
}
