using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;

namespace ByteBank.SistemaAgencia
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, mundo!");
            Console.WriteLine(123);
            Console.WriteLine(10.5);
            Console.WriteLine(true);

            object conta = new ContaCorrente(456, 234556);
            object desenvolvedor = new Desenvolvedor("1234567");

            string contaToString = conta.ToString();

            Console.WriteLine("Resultado: " + contaToString);
            Console.WriteLine(conta + "\n");

            Cliente carlos_1 = new Cliente();
            carlos_1.Nome = "Carlos";
            carlos_1.CPF = "234.876.345-34";
            carlos_1.Profissao = "Comedor de Pizza";

            Cliente carlos_2 = new Cliente();
            carlos_2.Nome = "Carlos";
            carlos_2.CPF = "234.876.345-34";
            carlos_2.Profissao = "Comedor de Pizza";

            ContaCorrente conta_2 = new ContaCorrente(456, 1236789);
            Console.WriteLine(conta.Equals(conta_2) + " ola");

            if(carlos_1.Equals(conta_2))
            {
                Console.WriteLine("São iguais");
            }
            else
            {
                Console.WriteLine("Não são iguais");
            }

            Console.ReadLine();

            //Console.WriteLine(conta);
            //Console.WriteLine(desenvolvedor);


            Console.ReadLine();

            conta.GetHashCode();
        }
        static void TestaString()
        {
            // Olá, meu nome é Lucas e você pode entrar em contato comigo
            // através do número 9753-2356!

            string padrao = "[0-9]{4,5}-?[0-9]{4}";

            string textoDeTeste = "Meu nome é Lucas, me ligue em 9953-2356";

            Match resultado = Regex.Match(textoDeTeste, padrao);
            //funciona sem o value... p mim foi mais intuitivo
            Console.WriteLine(resultado.Value);
            Console.ReadLine();

            // url Teste
            string urlTeste = "https://www.bytebank.com/cambio";
            int indiceByteBank = urlTeste.IndexOf("https://www.bytebank.com");

            Console.WriteLine(urlTeste.StartsWith("https://www.bytebank.com"));
            Console.WriteLine(urlTeste.EndsWith("cambio"));
            Console.WriteLine(urlTeste.Contains("bytebank"));

            Console.ReadLine();

            string urlParametros = "http://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar&valor=1500";
            ExtratorValorDeArgumentosURL extratorDeValores = new ExtratorValorDeArgumentosURL(urlParametros);

            string valorMoedaDestino = extratorDeValores.GetValor("moedaDestino");
            Console.WriteLine("Valor de moedaDestino: " + valorMoedaDestino);

            string valorMoedaOrigem = extratorDeValores.GetValor("moedaOrigem");
            Console.WriteLine("Valor de moedaOrigem: " + valorMoedaOrigem);

            Console.WriteLine(extratorDeValores.GetValor("VALOR"));

            Console.ReadLine();

            //paginas?argumentos
            //0123456789

            //+---+---+---+---+---+---+---+---+---+---+----+----+----+----+----+----+----+
            //| p | a | g | i | n | a | ? | a | r | g | u  | m  | e  | n  | t  | o  | s  |
            //| 0 | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 | 11 | 12 | 13 | 14 | 15 | 16 |
            //+---+---+---+---+---+---+---+---+---+---+----+----+----+----+----+----+----+

            //moedaOrigem = real & moedaDestino = dolar


            // Qnd o .IndexOf() n encontra o valor, ele diz q é -1.
            /*
            string teste2 = "afsgdhdfg";
            Console.WriteLine(teste2.IndexOf('1'));
            Console.ReadLine();
            */

            // Testando ´.ToUpper()´ e ´.ToLower()´
            string mensagemOrigem = "PALAVRA";
            string termoBusca = "ra";

            Console.WriteLine(mensagemOrigem.ToLower());
            Console.WriteLine(termoBusca.ToUpper());

            // Testando ´.Replace()´
            termoBusca = termoBusca.Replace('r', 'R');
            Console.WriteLine(termoBusca);

            termoBusca = termoBusca.Replace('a', 'A');
            Console.WriteLine(termoBusca);

            Console.WriteLine(mensagemOrigem.IndexOf(termoBusca));
            Console.ReadLine();

            // Testando o método Remove
            string testeRemocao = "primeiraParte&123456789";
            int indiceEComerncial = testeRemocao.IndexOf('&');
            Console.WriteLine(testeRemocao.Remove(indiceEComerncial, 4));
            Console.ReadLine();

            // <nome>=<valor>

            string palavra = "moedaOrigem=moedaDestino&moedaDestino=dolar";
            string nomeArgumento = "moedaDestino=";

            int indice = palavra.IndexOf(nomeArgumento);
            // palavra.Eu so qro o numero(int) q começa o nomeArgumento q é o "moedaDestino".
            Console.WriteLine(indice + "\n");

            //"moedaDestino".Tamanho do "moedaDestino" em numeros (12)
            Console.WriteLine("Tamanho da string nomeArgumento: " + nomeArgumento.Length + "\n");

            //Sentença completa para fazer comparação
            Console.WriteLine(palavra + "\n");

            //"Da sentença complesta, pegue e mostre só do indice(moedaDestino) pra frente
            Console.WriteLine(palavra.Substring(indice) + "\n");

            // "Pegue o indice, pule o numero de caracteres do nomeArgumento(12) e pule mais um".
            // me mostra oq sobrou disso.
            Console.WriteLine(palavra.Substring(indice + nomeArgumento.Length) + "\n");

            Console.ReadLine();

            // Testando IsNullOrEmpty
            string textoVazio = "";
            string textoNulo = null;
            string textoQualquer = "soidghspihi";

            Console.WriteLine(String.IsNullOrEmpty(textoVazio));
            Console.WriteLine(String.IsNullOrEmpty(textoNulo));
            Console.WriteLine(String.IsNullOrEmpty(textoQualquer));

            Console.ReadLine();

            // instanciar n vai funcionar pq so tem o atributo URL e ele é get somente
            ExtratorValorDeArgumentosURL extrator = new ExtratorValorDeArgumentosURL(null);

            string url = "pagina?moedaOrigem=real&moedaDestino=dolar";

            int indiceInterrogacao = url.IndexOf('?');
            Console.WriteLine(indiceInterrogacao);

            Console.WriteLine(url);

            string argumentos = url.Substring(indiceInterrogacao + 1);
            Console.WriteLine(argumentos);

            Console.ReadLine();
        }
    }
}
