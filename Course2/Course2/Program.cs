using System;
using System.Globalization;

namespace Couse2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* char genero = 'F';
             int idade = 32;
             double saldo = 10.35784;
             string nome = "Maria";

             Console.Write("Bom dia!");
             Console.WriteLine("Boa tarde!");
             Console.WriteLine("Boa noite!");
             Console.WriteLine("------------------------------------------");
             Console.WriteLine(genero);
             Console.WriteLine(idade);
             Console.WriteLine(saldo);
             Console.WriteLine(nome);
             Console.WriteLine(saldo.ToString("F2"));
             Console.WriteLine(saldo.ToString("F4"));
             Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));*/

            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";

            //Placeholders
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo);

            //interpolação
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais");

            //Concatenação 
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2") + " reais");

        }
    }
}
