using System;
namespace Course3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Conversão implícita e casting

            //implicita
            /*
            float x = 4.5f;

            double y = x;
            Console.WriteLine(y);

            */

            /*
            //casting

            double a;
            float b;

            a = 5.1;
            b = (float)a;
            Console.WriteLine(b);
            */

            /*
            double a;
            int b;

            a = 5.1;
            b = (int)a;

            Console.WriteLine(b);
            */
            int a = 5;
            int b = 2;

            double resultado = (double) a / b;
            Console.WriteLine(resultado);
        }
    }
}
