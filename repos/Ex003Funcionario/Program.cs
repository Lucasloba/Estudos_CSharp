// See https://aka.ms/new-console-template for more information

Console.WriteLine("Qual o seu nome completo?");
string nomeFuncionario = Console.ReadLine();
Console.WriteLine("Qual o valor do seu salário?");
double salarioFuncionario = Double.Parse(Console.ReadLine());

Console.WriteLine("O funcionário(a): " 
    + nomeFuncionario + 
    " tem um salário de " 
    + salarioFuncionario + 
    " em Setembro ");
