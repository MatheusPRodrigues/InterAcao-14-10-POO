using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    public class PagamentoBoleto : Pagamento
    {
        public override void ProcessarPagamento()
        {
            Console.Write("Informe o valor do boleto: ");
            this.SetValor(double.Parse(Console.ReadLine()));
            this.SetDataPagamento(DateTime.Now);            

            Console.Clear();
            Console.WriteLine($"Data de pagamento: {this.GetDataPagamento()}");
            Console.WriteLine("Valor total: " + this.GetValor().ToString("C"));
            Console.ReadKey();
        }
    }
}
