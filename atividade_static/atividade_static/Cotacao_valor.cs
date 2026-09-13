using System;
using System.Collections.Generic;
using System.Text;

namespace atividade_static
{
    internal class Cotacao_valor
    {
        public static double Iof = 6.00;
        public static double CotarValor(double cotacao, double valor)
        {
            double total = cotacao * valor;
            return total + (total * (Iof / 100.00));
        }
    }
}
