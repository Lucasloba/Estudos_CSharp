using ByteBank.Funcionarios;
using ByteBankHI;
using ByteBankHI.Funcionarios;
using ByteBankHI.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            //    Funcionario carlos = new Funcionario(2000, "546.879.159-20");

            //    carlos.Nome = "Carlos";

            //    Console.WriteLine(carlos.CPF);
            //    Console.WriteLine(Funcionario.TotalDeFuncionarios);

            //    carlos.AumentarSalario();
            //    Console.WriteLine("Novo salário do Carlos: " + carlos.Salario);

            //    gerenciador.Registrar(carlos);

            //    Console.WriteLine(carlos.Nome);
            //    Console.WriteLine(carlos.GetBonificacao());

            //    //-------------------------------------------//

            //    Diretor roberta = new Diretor("454.658.148-3");

            //    roberta.Nome = "Roberta";

            //    Console.WriteLine(roberta.CPF);
            //    Console.WriteLine(Funcionario.TotalDeFuncionarios);

            //    Funcionario robertaTeste = roberta;
            //    Console.WriteLine("Bonificação de uma referencia de Funcionário: " + robertaTeste.GetBonificacao());

            //    roberta.AumentarSalario();
            //    Console.WriteLine("Novo salário da Roberta: " + roberta.Salario);

            //    Console.WriteLine("Bonificação de uma referencia de Diretor: " + roberta.GetBonificacao());

            //    gerenciador.Registrar(roberta);

            //    Console.WriteLine(roberta.Nome);
            //    Console.WriteLine(roberta.GetBonificacao());

            //    //-------------------------------------------//

            ////  essa declaração funciona pois Diretor herda de Funcionario, portanto 
            ////  é possivel fazer referencia de um objeto a duas classes diferentes
            ////  quando, entre essas duas, uma herda da outra. Neste caso, Diretor herda
            ////  de Funcionario. 

            ////  Funcionario pedro = new Diretor();

            //    //-------------------------------------------//

            //    Console.WriteLine("Total de bonificações: " + gerenciador.GetTotalBonificacao());

            //    CalcularBonificacao();

            UsarSistema();

            Console.ReadLine();
        }
    
        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor claudio = new Diretor("754.652.963-26");
            claudio.Nome = "Cláudio";
            claudio.Senha = "321";

            GerenteDeConta rayssa = new GerenteDeConta("102.938.485-76");
            rayssa.Nome = "Rayssa";
            rayssa.Senha = "17";

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "123456";
            sistemaInterno.Logar(parceiro, "123456");

        

            sistemaInterno.Logar(claudio, "321");
            sistemaInterno.Logar(rayssa, "17");
        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Designer rodrigo = new Designer("522.538.532-54");
            rodrigo.Nome = "Rodrigo";

            Diretor claudio = new Diretor("754.652.963-26");
            claudio.Nome = "Cláudio";

            Auxiliar vicentina = new Auxiliar("974.456.256-24");
            vicentina.Nome = "Vicentina";

            GerenteDeConta rayssa = new GerenteDeConta("102.938.485-76");
            rayssa.Nome = "Rayssa";

            Desenvolvedor lucas = new Desenvolvedor("753.578.3456-94");
            lucas.Nome = "Lucas";

            gerenciadorBonificacao.Registrar(lucas);
            gerenciadorBonificacao.Registrar(rodrigo);
            gerenciadorBonificacao.Registrar(claudio);
            gerenciadorBonificacao.Registrar(vicentina);
            gerenciadorBonificacao.Registrar(rayssa);

            Console.WriteLine("Total de bonificações do mês: " + 
                gerenciadorBonificacao.GetTotalBonificacao());
        }

    }

}
