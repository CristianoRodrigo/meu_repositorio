using course15;
using System;
using System.Globalization;

namespace couse15
{
    class Progrma
    {
        static void Main(string[] args)
        {
            // Exercicio geral: criar uma tabela de escolhar mostrando se ele quer adicionar, remover, continuar ou sair. Fazendo o ciclo de repetição também.
            Produto p = new Produto();

            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            // o TryParse funciona para transformar a resposta que não é a variavel certa, nela (exemplo: é double, mas a resposta é char ele força a trasnformar em double, ele retorna true ou false. 
            // Exercicio desafio: quando retornar um false fazer aparecer uma mensagem de erro e voltar para a tabela de escolha.
            var isprice = double.TryParse(Console.ReadLine(), CultureInfo.InvariantCulture, out var price);
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            Console.WriteLine();
            Console.WriteLine($"Dados atualizados: \n {p}");

            Console.WriteLine();

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido ao estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);

            Console.WriteLine($"Dados atualizados: \n {p}");
        }
    }
}