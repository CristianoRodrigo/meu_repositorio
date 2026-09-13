using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora
{
    internal class Calculadora
    {
        public double num1, num2;

        public void TabelaCalculadora()
        {
            Console.WriteLine("===========Calculadora================");
            Console.WriteLine("1. Somar");
            Console.WriteLine("2. Subtrair");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.WriteLine("0. Sair");
            Console.WriteLine("=======================================");
        }

        public double Somar()
        {
            return num1 + num2;
        }

        public double Subtracao()
        {
            return num1 - num2;
        }

        public double Multiplicacao()
        {
            return num1 * num2;
        }

        public double Dividir()
        {
            return num1 / num2;
        }

    }
}
