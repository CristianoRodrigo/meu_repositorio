using System;

namespace atividade_while
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // exercicio 1
            Console.Write("Digite uma senha: ");
            int senha = int.Parse(Console.ReadLine());
            while (senha != 2022)
            {
                Console.WriteLine("Senha Invalida");
                Console.Write("Digite uma senha: ");
                senha = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso Permitido");
            */

            // exercicio 3
            int gasolina = 0, diesel = 0, alcool = 0;
            
            cardapio();

            Console.Write("Escolha uma opção: ");
            int opcao = int.Parse(Console.ReadLine());

            while (opcao != 4 )
            {
                cardapio();

                if (opcao == 1)
                {
                    alcool += 1;
                } else if (opcao == 2)
                {
                    gasolina += 1;
                } else if (opcao == 3)
                {
                    diesel += 1;
                }
                else { }
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Muito Obrigado!");
            Console.WriteLine($"Álcool: {alcool}");
            Console.WriteLine($"Gasolina: {gasolina}");
            Console.WriteLine($"diesel: {diesel}");

        }
        static void cardapio()
        {
            Console.WriteLine("1. Álcool");
            Console.WriteLine("2. Gasolina");
            Console.WriteLine("3. Diesel");
            Console.WriteLine("4. Fim");
        }
    }
}