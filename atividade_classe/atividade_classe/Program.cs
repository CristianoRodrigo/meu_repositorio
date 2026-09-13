using System;
using System.Globalization;

namespace atividade_classe
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // atividade 1
            Pessoa p1, p2;
            p1 = new Pessoa();
            p2 = new Pessoa();

            Console.WriteLine("Digite seu Nome: ");
            p1.Nome = Console.ReadLine();

            Console.WriteLine("Digite sua idade: ");
            p1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu Nome: ");
            p2.Nome = Console.ReadLine();

            Console.WriteLine("Digite sua idade: ");
            p2.Idade = int.Parse(Console.ReadLine());

            if ( p1.Idade >  p2.Idade )
            {
                Console.WriteLine($"O mais velho é: {p1.Nome}");
            } else
            {
                Console.WriteLine($"O mais velho é: {p2.Nome}");
            }
            */

            // atividade 2

            Funcionario f1, f2;
            f1 = new Funcionario();
            f2 = new Funcionario();

            double media;

            Console.WriteLine("Digite seu nome: ");
            f1.Nome = Console.ReadLine();

            Console.WriteLine("Digite seu salário: ");
            f1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite seu nome: ");
            f2.Nome = Console.ReadLine();

            Console.WriteLine("Digite seu salário: ");
            f2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = (f1.Salario + f2.Salario)/ 2;

            Console.WriteLine($"Salário médio é: {media.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}