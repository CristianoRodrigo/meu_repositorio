using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Text;

namespace AtivSecao5
{
    internal class Banco
    {
        public int NumBanco { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }

        public Banco(int numbanco, string nome)
        {
            NumBanco = numbanco;
            Nome = nome;
        }

        public Banco(int numbanco, string nome, double saldo) : this (numbanco, nome)
        {
            Saldo = saldo;
        }

        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        public void Sacar(double valor)
        {
            Saldo -= (valor + 5);
        }

        public override string ToString()
        {
            return $"Conta: {NumBanco}, Titular: {Nome}, Saldo: ${Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
