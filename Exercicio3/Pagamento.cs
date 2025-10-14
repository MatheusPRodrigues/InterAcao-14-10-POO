using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    public abstract class Pagamento
    {
        private double Valor;
        private DateTime DataPagamento;

        public void SetValor(double Valor)
        {
            this.Valor = Valor;
        }

        public double GetValor()
        {
            return this.Valor;
        }

        public void SetDataPagamento(DateTime dateTime)
        {
            this.DataPagamento = dateTime;
        }

        public DateTime GetDataPagamento()
        {
            return this.DataPagamento;
        }

        public abstract void ProcessarPagamento();
    }
}
