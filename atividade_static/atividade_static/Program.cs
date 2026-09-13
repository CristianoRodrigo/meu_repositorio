using System.Globalization;

namespace atividade_static
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar: ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar: ");
            double comprar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double valortotal = Cotacao_valor.CotarValor(cotacao, comprar);

            Console.WriteLine($"Valor a ser pago em reais = {valortotal.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}