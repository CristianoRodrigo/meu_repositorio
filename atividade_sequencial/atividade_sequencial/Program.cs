using System;

namespace atividade_sequencial
{
    class Program
    {
        static void Main(String[] args)
        {
            /*
            // Atividade 1
            Console.WriteLine("Digite o primeiro numero: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int n2 = int.Parse(Console.ReadLine());

            int soma = n1 + n2;
            Console.WriteLine($"A soma de {n1} + {n2} = {soma}");
            */

            /*
            // Atividade 2
            double pi = 3.14159;
            Console.WriteLine("Digite o valor do raio: ");
            double raio1 = double.Parse(Console.ReadLine());

            double total = pi * (raio1 * raio1);
            Console.WriteLine($"A área do do raio é: {total.ToString("F4")}");
            */


            // Atividade 3
            Console.WriteLine("Digite o valor de A: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de B: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de C: ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de D: ");
            int d = int.Parse(Console.ReadLine());

            int diferenca = (a * b) - (c * d);

            Console.WriteLine($"Diferença: {diferenca}");
        }
    }
}