/* PROVA DE LÓGICA NÉLIO ALVES | C# */

namespace Prova_Logica_de_Programacao.exercicios
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Ex1();
            //Ex2();
            //Ex3();
            //Ex4();
            //Ex5();
            //Ex6();
        }

        static void Ex1()
        {
            int codPUm;
            int qntPUm;
            double valorPUm;
            double result;

            Console.WriteLine("Código peça_1: ");
            codPUm = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Quantidade peça_1: ");
            qntPUm = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Valor peça_1: ");
            valorPUm = Convert.ToDouble(Console.ReadLine());

            int codPDois;
            int qntPDois;
            double valorPDois;

            Console.WriteLine("Código peça_2: ");
            codPDois = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Quantidade peça_2: ");
            qntPDois = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Valor peça_2: ");
            valorPDois = Convert.ToDouble(Console.ReadLine());

            result = qntPUm * valorPUm + qntPDois * valorPDois;
            Console.WriteLine("total: " + result);
        }
        static void Ex2() 
        {
            double raio;
            double pi = 3.14159;
            float area;

            Console.WriteLine("Fala o raio: ");
            raio = Convert.ToDouble(Console.ReadLine());
            area = (float)(Math.Pow(raio,2) * pi);
            Console.WriteLine("A área do círculo é " + area);

        }
        static void Ex3() 
        {
            double CQ = 4.00;
            double XS = 4.50;
            double XB = 5.00;
            double TS = 2.00;
            double RF = 1.50;

            int cod;
            int qtd;
            double total;

            Console.WriteLine("Fala o cod do item: ");
            cod = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Fala a quantidade: ");
            qtd = Convert.ToInt32(Console.ReadLine());

            if (cod == 1)
            {
                total = CQ * qtd;
                Console.WriteLine("Total : " + total);
            }
            else if (cod == 2)
            {
                total = XS * qtd;
                Console.WriteLine("Total : " + total);
            }
            else if (cod == 3)
            {
                total = XB * qtd;
                Console.WriteLine("Total : " + total);
            }
            else if (cod == 4)
            {
                total = TS * qtd;
                Console.WriteLine("Total : " + total);
            }
            else if (cod == 5)
            {
                total = RF * qtd;
                Console.WriteLine("Total : " + total);
            }
        }
        static void Ex4()
        {
            double a, b, c, delta, xUm, xDois;

            Console.WriteLine("Fala o valor de A :");
            a = Convert.ToDouble(Console.ReadLine());

            if (a == 0) { Console.WriteLine("Impossível Calcular. A tem q ser diferente de 0"); return; }
         
            Console.WriteLine("Fala o valor de B :");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Fala o valor de C :"); 
            c = Convert.ToDouble(Console.ReadLine());

            delta = Math.Pow(b, 2) - 4 * a * c;

            if (delta < 0) { Console.WriteLine("Impossível Calcular. N pd delta negativo"); return; }

            xUm = (-b + Math.Sqrt(delta)) / (2 * a);
            xDois = (b + Math.Sqrt(delta)) / (2 * a);

            Console.WriteLine($"X1 = {xUm} e X2 = {xDois}");
        }
        static void Ex5()
        {
            int senhaCorreta = 2002, tentativa;

            do 
            {
                Console.WriteLine("Digite a senha :");
                tentativa = Convert.ToInt32(Console.ReadLine());
                if (tentativa != senhaCorreta) { Console.WriteLine("Senha incorreta. Tente novamente"); }
                Thread.Sleep(1500);
                Console.Clear();
            } while (tentativa != senhaCorreta);

            Console.WriteLine("Acesso Permitido! =)");
            Thread.Sleep(3000);
        }
        static void Ex6()
        {
            int n;

            List<int> listaNumerosIN = new List<int>();
            List<int> listaNumerosOUT = new List<int>();

            Console.WriteLine("Digite a quantidade de números : ");
            
            int i = 0;
            do
            {
                n = Convert.ToInt32(Console.ReadLine());
                if (n >= 10 && n <= 20)
                {
                    listaNumerosIN.Add(n);
                    var a = listaNumerosIN.First();
                    listaNumerosIN.Remove(a);
                    
                }
                else
                {
                    listaNumerosOUT.Add(n);
                }
                i++;
            } while (i < n); 
                
            foreach (var item in listaNumerosIN)
            {
                Console.WriteLine(item + " in");
            }

            foreach (var item in listaNumerosOUT)
            {
                Console.WriteLine(item + " out");
            }
        }
    }
}