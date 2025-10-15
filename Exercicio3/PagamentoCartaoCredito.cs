using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    public class PagamentoCartaoCredito : Pagamento
    {
        public override void ProcessarPagamento()
        {
            Console.WriteLine("Digite o valor a pagar: ");
            this.SetValor(double.Parse(Console.ReadLine()));

            this.SetDataPagamento(DateTime.Now);

            const double TAXADOCARTAO = 10.00;
            
            Console.Clear();
            Console.WriteLine("Pagamento com cartão realizado");
            Console.WriteLine($"Valor do pagamento: {this.GetValor():C}");
            Console.WriteLine($"Taxa fixa do cartão: {TAXADOCARTAO:C}");
            Console.WriteLine($"Data de pagamento: {this.GetDataPagamento()}");
            Console.WriteLine($"Valor total: {this.GetValor() + TAXADOCARTAO:C}");
            Console.ReadKey();
        }
    }
}
