using System;
using System.Globalization;
namespace atividade
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             // Atividade 1
            string produto1 = "Computador", produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0, preco2 = 650.50, medida = 53.234567;

            Console.WriteLine($"Produtos:\n{produto1} cujo preço é $ {preco1:F2} \n{produto2} cujo preco é $ {preco2:F2}");
            Console.WriteLine($"\nRegistro: {idade} anos de idade, código {codigo} e gênero: {genero}");
            Console.WriteLine($"\nMedida com oito casas decimais: {medida}\nArredondado (três cas adecimais): {medida:F3}");
            Console.WriteLine("Separador decimal invariant culture: {0}", medida.ToString("F3", CultureInfo.InvariantCulture));
            */


            //atividade 2
            Console.WriteLine("Digite seu nome Completo: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa: ");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto: ");
            double valorprod = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha)");
            string[] descricao = Console.ReadLine().Split(' ');
            string ult_name =descricao[0];
            int idade = int.Parse(descricao[1]);
            double altura = double.Parse(descricao[2], CultureInfo.InvariantCulture);

            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(valorprod.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(ult_name);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
