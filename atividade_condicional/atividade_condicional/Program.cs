using System;
using System.Numerics;

namespace atividade_condicionl
{
    class Program
    {
        static void Main(String[] args)
        {
            /*
            Console.WriteLine("Digite um número inteiro: ");
            int num = int.Parse(Console.ReadLine());

            if (num < 0)
            {
                Console.WriteLine("Negativo");
            } else
            {
                Console.WriteLine("Não negativo");
            }
            */
            /*
            Console.WriteLine("Digite um numero inteiro: ");
            int num = int.Parse(Console.ReadLine());

            if ( num % 2 == 0)
            {
                Console.WriteLine("Par!");
            } else
            {
                Console.WriteLine("Impar");
            }
            */

            Console.WriteLine("Digite o código do produto: ");
            int produ = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade: ");
            int quanti = int.Parse(Console.ReadLine());

            double total = 0;

            if (produ == 1)
            {
                total = (double) 4.00 * quanti;
            }
            else if (produ == 2)
            {
                total = (double) 4.5 * quanti;
            }
            else if (produ == 3)
            {
                total = (double) 5.00 * quanti;
            }
            else if (produ == 4)
            {
                total = (double) 2.00 * quanti;
            }
            else if (produ == 5)
            {
                total = (double) 1.5 * quanti;
            } else
            {
                Console.WriteLine("Digite um produto válido");
                return;
            }

            Console.WriteLine($"O valor a pagar é: R$ {total.ToString("F2")}");

        }
    }
}