﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos 
{ 
    public class CalculadoraEstatica {

        // Método de Classe ou Método estático!!! de classe
        public static int Multiplicar(int a, int b) {
            return a * b;
        }

        // Método de instância!!! de objeto 
        public int Somar(int a, int b) { //"static" método (fica parado) pertence a classe e n ao objetico
            return a + b;
        }
    }
       
    class MetodosEstaticos 
    {
        public static void Executar () {
            var resultado = CalculadoraEstatica.Multiplicar(2, 2);
            Console.WriteLine("Resultado: {0}", resultado);

            CalculadoraEstatica calc = new CalculadoraEstatica();
            Console.WriteLine(calc.Somar(2, 2)); 
           
            // qnd tem "static" (no caso o multiplicar) precisa instanciar (colocar "calculadoraEstatica")
            // qnd n tem "static" (no caso o somar) vc pode so declarar a variavel (no caso "calc") 
        }
    }
}
