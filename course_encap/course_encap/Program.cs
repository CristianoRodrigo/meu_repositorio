using Course_encap;
using System;
using System.Globalization;
using System.Runtime.Intrinsics.X86;

namespace Course_encap
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 500.00, 10);

            p.Nome = "T";

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);

            
        }
    }
}