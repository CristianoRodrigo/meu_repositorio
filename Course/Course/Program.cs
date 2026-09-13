using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            //mostra como funciona cara tipo de variavel
            /*bool completo = false;
            char genero = 'F';
            char letra = '\u0041';
            byte n1 = 126;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L;
            float n5 = 4.5f;
            double n6 = 4.5;
            string nome = "Maria Green";
            object obj1 = "Alex Brown";
            object obj2 = 4.5f;

            
            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);*/

            int n1 = int.MinValue;
            int n2 = int.MaxValue;
            sbyte n3 = sbyte.MinValue;
            sbyte n4 = sbyte.MaxValue;
            decimal n5 = decimal.MaxValue;

            int inteste = 10;
            Teste(inteste);
            
            
        }


        public static void Teste(int n)
        {
            Console.WriteLine(n);
            Console.WriteLine("insira um numero");
            var input = Console.ReadLine();
            Console.WriteLine(input);

            Console.WriteLine($"O numero é : {input}");
        }

       

    }

    

}
