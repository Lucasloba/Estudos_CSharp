using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExLadosPoligono
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nLados;
            double medidaLado;
            double area;

            Console.WriteLine("Insira o número de Lados");
            nLados = Convert.ToInt32(Console.ReadLine());

            if(nLados < 3)
            {
                Console.WriteLine("NÃO É UM POLÍGONO");
            }
            else
            {
                if(nLados > 5)
                {
                    Console.WriteLine("POLÍGONO NÃO IDENTIFICADO");
                }
                else
                {
                    if(nLados == 5)
                    {
                        Console.WriteLine("PENTAGONO");
                    }
                    else
                    {
                        Console.WriteLine("Informe a medida de um lado em cm");
                        medidaLado = Convert.ToDouble(Console.ReadLine());

                        if (nLados == 3)
                        {
                            area = medidaLado * medidaLado / 2;
                            Console.WriteLine("TRIÂNGULO. Área: " + area + " cm");
                        }
                        else
                        {
                            area = medidaLado * medidaLado;
                            Console.WriteLine("QUADRADO. Área: " + area + " cm");
                        }
                    }
                }
            } 
        }
    }
}
