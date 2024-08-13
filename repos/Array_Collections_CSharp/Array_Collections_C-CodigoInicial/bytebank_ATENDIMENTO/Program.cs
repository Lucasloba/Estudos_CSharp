using bytebank.Modelos.Conta;
using bytebank_ATENDIMENTO.bytebank.Atendimento;
using bytebank_ATENDIMENTO.bytebank.Util;

Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");

#region Exemplos Arrays em C#
//TestaArraysInt();
//TestaBucarPalavra();


void TestaArraysInt()
{
    int[] idades = new int[] { 30, 40, 17, 21, 18 };

    //idades[0] = 30;
    //idades[1] = 40;
    //idades[2] = 17;
    //idades[3] = 21;
    //idades[4] = 18;

    Console.WriteLine($"Tamanho do Array {idades.Length}");

    int acumulador = 0;

    for (int i = 0; i < idades.Length; i++)
    {
        int idade = idades[i];
        Console.WriteLine($"Índice [{i}] = {idade}");
        acumulador += idade;
        // acumiulador vai pegar a primeira idade e somar. dps o resultado, somar com
        // a segunda idade e assim sucessivamente ate o "i" ser 5. 
        // 0 + 30 = 30
        // 30 + 40 = 70
        // 70 + 17 = 87
        // 87 + 21 = 108
        // 108 + 18 = 126
    }

    // dps vai ser usado no calc. da média
    // media = 126 / 5 = 25,2 q é aproximadamente 25
    int media = acumulador / idades.Length;
    Console.WriteLine($"Média de idades = {media}");
}

void TestaBucarPalavra()
{
    string[] arrayDePalavras = new string[5];

    for (int i = 0; i < arrayDePalavras.Length; i++)
    {
        Console.Write($"Digite {i + 1}ª Palavra: ");
        arrayDePalavras[i] = Console.ReadLine();
    }

    Console.Write("Digite palavra a ser encontrada: ");
    var busca = Console.ReadLine();

    //string palavra vai percorrer o arrayDePalavras preenchidono for e fará o if 
    // de comparar se ela (a palavra) é igual a ´busca´ que tem a palavra q deve ser encontrada
    foreach (string palavra in arrayDePalavras)
    {
        if (palavra.Equals(busca))
        {
            Console.WriteLine($"Palvra encontrada = {busca}.");
            break;
        }
    }

    //
    //foreach (var item in collection)
    //{
    //   código que deve ser executado a cada procura
    //}
}

//Array amostra = new double[5];
Array amostra = Array.CreateInstance(typeof(double),5);
amostra.SetValue(5.9, 0);
amostra.SetValue(1.8, 1);
amostra.SetValue(7.1, 2);
amostra.SetValue(10, 3);
amostra.SetValue(6.9, 4);

// [5.9][1.8][7.1][10][6.9] Calcular a mediana desse Array

// TestaMediana(amostra);

void TestaMediana(Array array)
{
    if((array == null || array.Length == 0))
    {
        Console.WriteLine("Array para cálculo da mediana está vazio ou nulo.");
    }

    // expressao para organizar o array q for setado
    double[] numerosOrdenados = (double [])array.Clone();
    //´Sort()´ organiza os dados do array em ordem crescrente
    Array.Sort(numerosOrdenados);

  int tamanho = numerosOrdenados.Length;
  int meio = tamanho / 2;
  double mediana = (tamanho % 2 != 0) ? numerosOrdenados[meio] :
                                    (numerosOrdenados[meio] + numerosOrdenados[meio - 1]) / 2;


    //if(tamanho % 2 != 0)         *** pra ficar mais facil de entender a expressao acima ***
    //{                             
    //  numerosOrdenados[meio];
    //}
    //else            
    //{
    //  (numerosOrdenados[meio] + numerosOrdenados[meio - 1]) / 2;
    //}

    Console.WriteLine($"Com base na amostra a mediana = {mediana}");
}

// Cuidado ao dizer o tamanho do array
/*
int[] valores = { 10, 58, 36, 57 };

try
{
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine(valores[i]);
    }
} //excessao de qnd a estrutura de repeticao repete mais que o tamanho do array
catch (IndexOutOfRangeException)
{
    Console.WriteLine
        ("Você deve ter colocado um numero de iterações maior que o tamanho do array");
}
*/

void TestaArrayDeContasCorrentes()
{
    //int valores = new int[] { 1, 2, 3, 5 };
    ListaDeContasCorrentes listaDeContas = new ListaDeContasCorrentes();

    listaDeContas.Adicionar(new ContaCorrente(874, "5679787-A"));
    listaDeContas.Adicionar(new ContaCorrente(874, "4456668-B"));
    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));
    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));
    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));
    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));
    //listaDeContas.Adicionar(new ContaCorrente(944, "bAbalu"));

    var contaDoAndre = new ContaCorrente(963, "123456-X");
    listaDeContas.Adicionar(contaDoAndre);
    //listaDeContas.ExibirLista();
    //Console.WriteLine("=====================");
    //listaDeContas.Remover(contaDoAndre);
    //listaDeContas.ExibirLista();

    //implementação do index (localizar o item pelo índice)
    for (int i = 0; i < listaDeContas.Tamanho; i++)
    {
        //Console.WriteLine("fala o indice da conta q c qr ver");
        //i = Convert.ToInt32(Console.ReadLine());
        
        ContaCorrente conta = listaDeContas[i];
        Console.WriteLine($"Indice [{i}] = {conta.Conta}/{conta.Numero_agencia}");
    }

}

//TestaArrayDeContasCorrentes();
#endregion 

#region Exemplos de uso do List
//List<ContaCorrente> _listaDeContas2 = new List<ContaCorrente>();
//{
//  new ContaCorrente(874, "765423-A");
//  new ContaCorrente(874, "234567-B");
//  new ContaCorrente(874, "765423-C");
//}

//List<ContaCorrente> _listaDeContas3 = new List<ContaCorrente>()
//{
//  new ContaCorrente(951, "5679787-E"),
//  new ContaCorrente(321, "4456668-F"),
//  new ContaCorrente(719, "7781438-G")
//};

//_listaDeContas2.AddRange(_listaDeContas3);
//_listaDeContas2.Reverse();

//// Saída com 6 elementos (conectando a lista 2 com a 3

//for (int i = 0; i < _listaDeContas2.Count; i++)
//{
//    Console.WriteLine($"Indice[{i}] = Conta [{_listaDeContas2[i].Conta}]");
//}

//Console.WriteLine("\n\n");

//var range = _listaDeContas3.GetRange(0, 1);
////Pega um item pelo indice
//for (int i = 0; i < range.Count; i++)
//{
//    Console.WriteLine($"Indice[{i}] = Conta [{range[i].Conta}]");

//}

//Console.WriteLine("\n\n");

//_listaDeContas3.Clear();
//for (int i = 0; i < _listaDeContas3.Count; i++)
//{
//    Console.WriteLine($"Indice[{i}] = Conta [{range[i].Conta}]");
//}
#endregion

#region Lista<T>Exemplo
//Generica<int> teste1 = new Generica<int>();

//teste1.MostrarMensagem(234);

//Generica<string> teste2 = new Generica<string>();

//teste2.MostrarMensagem("Olá Mundo!");

//public class Generica<T>
//{
//    public void MostrarMensagem(T t)
//    {
//        Console.WriteLine($"Exibindo {t}");
//    }
//}
#endregion

//Instanciando a moda antiga XD

//ByteBankAtendimento aaaa = new ByteBankAtendimento();
//aaaa.AtendimentoCliente();

new ByteBankAtendimento().AtendimentoCliente();




