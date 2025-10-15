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
            SetValor(double.Parse(Console.ReadLine()));
            SetDataPagamento(DateTime.Now);            

            Console.Clear();
            Console.WriteLine($"Data de pagamento: {GetDataPagamento()}");
            Console.WriteLine("Valor total: " + GetValor().ToString("C"));
            Console.ReadKey();
        }
    }
}
