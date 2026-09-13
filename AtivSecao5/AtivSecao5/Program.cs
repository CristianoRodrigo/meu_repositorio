using System.Globalization;

namespace AtivSecao5
{
    class Program
    {
        static void Main(string[] args)
        {
            Banco conta;

            Console.WriteLine("Digite o número da conta: ");
            int numconta = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o nome do titular");
            string nome = Console.ReadLine();
            Console.WriteLine("Hávera dépósito inicial (s/n)?");
            string escolha = Console.ReadLine();
            if (escolha == "s")
            {
                Console.WriteLine("Entre o valor de depósito inicial: ");
                double valorinicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new Banco(numconta, nome, valorinicial);
            }
            else
            {
                conta = new Banco(numconta, nome);
            }

            Console.WriteLine($"Dados da conta: \n {conta}");

            Console.WriteLine("Entre um valor para depósito: ");
            double valor = double.Parse(Console.ReadLine());

            conta.Deposito(valor);
            Console.WriteLine($"Dados da conta: \n {conta}");

            Console.WriteLine("Entre um para saque: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if( valor <= conta.Saldo)
            {
                conta.Sacar(valor);
            }
            else
            {
                Console.WriteLine("Valor inválido!");
            }
            

            Console.WriteLine($"Dados da conta: \n {conta}");
        }
    }
}