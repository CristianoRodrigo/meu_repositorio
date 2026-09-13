using System;

namespace atividade_for
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro até 1000: ");
            int num = int.Parse(Console.ReadLine());

            if (num >= 1 && num <= 1000)
            {
                Console.WriteLine("Os numeros impares são: ");

                for (int i = 1; i <= num; i++)
                {
                    if (i % 2 == 1)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else
            {
                Console.WriteLine("Valor invalido");
            }
        }
    }
}