using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    public class ContaBancaria
    {
        private decimal Saldo;
        private string Titular;

        public decimal GetSaldo()
        {
            return this.Saldo;
        }

        public void SetTitular(string titular)
        {
            this.Titular = titular;
        }

        public string GetTitular()
        {
            return this.Titular;
        }

        public bool Sacar(decimal valor)
        {
            if (valor <= this.Saldo)
            {
                this.Saldo -= valor;
                return true;
            }
            return false;
        }

        public void Depositar(decimal valor)
        {
            this.Saldo += valor;
        }
    }
}
