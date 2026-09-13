
using System.Globalization;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calculadora = new Calculadora();
            int opcao = 1;
            double total;

            while(opcao != 0)
            {
                calculadora.TabelaCalculadora();
                Console.WriteLine("Digite uma das opções: ");
                while (!int.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out opcao) || opcao < 0)
                {
                    Console.Write("Opção inválida! Digite novamente: ");
                }

                switch(opcao)
                {
                    case 1:
                        Console.WriteLine("Digite o número 1: ");
                        while(!double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out calculadora.num1))
                        {
                            Console.WriteLine("Opção inválida! Digite novamente: ");
                        }
                        Console.WriteLine("Digite o número 2: ");
                        while (!double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out calculadora.num2))
                        {
                            Console.WriteLine("Opção inválida! Digite novamente: ");
                        }
                        total = calculadora.Somar();
                        Console.WriteLine($"A soma de {calculadora.num1} + {calculadora.num2} = {total}");
                        break;

                    case 2:
                        Console.WriteLine("Digite o número 1: ");
                        while (!double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out calculadora.num1))
                        {
                            Console.WriteLine("Opção inválida! Digite novamente: ");
                        }
                        Console.WriteLine("Digite o número 2: ");
                        while (!double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out calculadora.num2))
                        {
                            Console.WriteLine("Opção inválida! Digite novamente: ");
                        }
                        total = calculadora.Subtracao();
                        Console.WriteLine($"A subtração de {calculadora.num1} - {calculadora.num2} = {total}");
                        break;

                    case 3:
                        Console.WriteLine("Digite o número 1: ");
                        while (!double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out calculadora.num1))
                        {
                            Console.WriteLine("Opção inválida! Digite novamente: ");
                        }
                        Console.WriteLine("Digite o número 2: ");
                        while (!double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out calculadora.num2))
                        {
                            Console.WriteLine("Opção inválida! Digite novamente: ");
                        }
                        total = calculadora.Multiplicacao();
                        Console.WriteLine($"A multiplicação de {calculadora.num1} x {calculadora.num2} = {total}");
                        break;

                    case 4:
                        Console.WriteLine("Digite o número 1: ");
                        while (!double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out calculadora.num1))
                        {
                            Console.WriteLine("Opção inválida! Digite novamente: ");
                        }
                        Console.WriteLine("Digite o número 2: ");
                        while (!double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out calculadora.num2) || calculadora.num2 == 0)
                        {
                            Console.WriteLine("Opção inválida! Digite novamente: ");
                        }
                        total = calculadora.Dividir();
                        Console.WriteLine($"A Divisão de {calculadora.num1} / {calculadora.num2} = {total}");
                        break;

                    case 0:
                        Console.WriteLine("Saindo!");
                        opcao = 0;
                        break;

                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

            }

        }
    }
}