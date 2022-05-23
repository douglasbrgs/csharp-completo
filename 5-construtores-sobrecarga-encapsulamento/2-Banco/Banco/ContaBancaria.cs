using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Banco
{
    class ContaBancaria
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }
        public double TaxaSaqueEmReais { get; private set; } = 5.0;

        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        public ContaBancaria(int numero, string titular, double depositoInicial) : this(numero, titular)
        {
            Depositar(depositoInicial);
        }

        public void Depositar(double quantia)
        {
            if (quantia > 0)
            {
                Saldo += quantia;
            }
        }

        public void Sacar(double quantia)
        {
            if (quantia > 0)
            {
                Saldo -= quantia;
                Saldo -= TaxaSaqueEmReais;
            }
        }

        public override string ToString()
        {
            return $"Conta {Numero}, Titular: {Titular}, Saldo: $ {Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
