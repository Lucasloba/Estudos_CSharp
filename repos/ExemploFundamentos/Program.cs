using ExemploFundamentos.Models;

// INcrementando e Decrementando 
//int num = 10;
//Console.WriteLine(num);
//Console.WriteLine("Incrementando o 10");
//num++;
//Console.WriteLine(num);
//
//int nume = 10;
//Console.WriteLine(nume);
//Console.WriteLine("Decrementando o 10");
//nume--;
//Console.WriteLine(nume);

// Classe Calculadora
Calculadora calculator = new Calculadora();
calculator.Somar(1, 2);
calculator.Subtrair(1, 2);
calculator.Multiplicar(1, 2);
calculator.Dividir(1, 2);
calculator.Modulo(1, 2);
calculator.Potencia(11, 2);
calculator.Seno(30);
calculator.Coseno(30);
calculator.Tangente(30);
calculator.RaizQuadrada(25);
Console.WriteLine(calculator);

// Operador NOT !
//bool choveu = false;
//bool estaTarde = false;
//
//if (!choveu && !estaTarde) { Console.WriteLine("Vou pedalar"); } 
//else { Console.WriteLine("n vou pedalar"); }

// Operador E &&
// bool presencaMinina = false;
// double media = 8;
// 
// if (presencaMinina && media >= 7) { Console.WriteLine("Aprovado"); }
// else{ Console.WriteLine("Reprovado"); }

// Operador OU ||
// bool ehMaiorDeIdade = false;
// bool possuiAutorizacaoDoResponsavel = true;
//
// if (ehMaiorDeIdade || possuiAutorizacaoDoResponsavel) {Console.WriteLine("Pode entrar");}
// else {Console.WriteLine("Não pd entrar");}

//Console.WriteLine("Digite uma letra");
//string letra = Console.ReadLine();
//
//switch (letra)
//{
//    case "a":
//    case "e":
//    case "i":
//    case "o":
//    case "u":
//        Console.WriteLine("É uma vogal");
//        break;
//    default:
//        Console.WriteLine("Não é uma vogal");
//        break;
//}

//int quantidadeEmEstoque = 1;
//int quantidadeCompra = 1;
//bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;
//
//Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
//Console.WriteLine($"Quantidade da compra: {quantidadeCompra}");
//Console.WriteLine($"É possível realizar a venda? {possivelVenda}");
//
//if (quantidadeCompra == 0) { Console.WriteLine("Venda inválida");}
//else if (possivelVenda) {Console.WriteLine("Venda realizada.");}
//else {Console.WriteLine("Desculpe, n temos a quantidade exata em estoque.");}

//Segurança de conversão
//string a = "15-";
// //int b = 0; 
// //Tenta converter o "a", se n conseguir a saída(out) será "b"
//int.TryParse(a, out int b);
//Console.WriteLine(b);
//Console.WriteLine("Conversão realizada com sucesso!");

//Cast implícito
// int a = 5;
// double b = a;
// Console.WriteLine(b);

//int inteiro = 5;
//string a = inteiro.ToString();
//Console.WriteLine(a);

// Cast - Casting
//int a = Convert.ToInt32(null);
//int b = Int32.Parse(null);
// Parse n aceita null, Convert aceita retornando 0 
//Console.WriteLine(a);

// TIPO DATE TIME
//DateTime dataAtual = DateTime.Now.AddDays(5);
//Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));

// Variaveis
//string apresentacao = "Hello, Wellcome!";
//int quantidade = 1;
//double altura = 1.80;
//decimal preco = 1.80M;
//bool condicao = true;
//Console.WriteLine("Valor da váriavel apresentacao: " + apresentacao);
//Console.WriteLine("Valor da váriavel quantidade: " + quantidade);
//Console.WriteLine("Valor da váriavel altura: " + altura.ToString("0.00"));
//Console.WriteLine("Valor da váriavel preco: " + preco);
//Console.WriteLine("Valor da váriavel preco: " + condicao);

// Pessoa pessoaUm = new Pessoa();
// 
// pessoaUm.Nome = "Lucas";
// pessoaUm.Idade = 19;
// pessoaUm.Apresentar();
// 
// double valor = 10.30500;
