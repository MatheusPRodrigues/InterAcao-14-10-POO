// 1. Abstração – Sistema de Pagamentos

using Exercicio3;

void RealizarPagamento(Pagamento pagamento)
{
    pagamento.ProcessarPagamento();
}

void MenuPrincinpal()
{
    bool repetir = true;

    do
    {
        Console.Clear();

        Console.WriteLine("==== P A G A M E N T O ====");
        Console.WriteLine("1 - Pagar com boleto");
        Console.WriteLine("2 - Pagar com cartão de crédito");
        Console.WriteLine("0 - Sair");
        string opcaoDoCliente = Console.ReadLine();

        switch (opcaoDoCliente)
        {
            case "1":
                PagamentoBoleto pagamentoBoleto = new PagamentoBoleto();
                RealizarPagamento(pagamentoBoleto);
                break;
            case "2":
                PagamentoCartaoCredito pagamentoCartaoCredito = new PagamentoCartaoCredito();
                RealizarPagamento(pagamentoCartaoCredito);
                break;
            case "0":
                Console.Clear();
                Console.WriteLine("Programa encerrado!");
                repetir = false;
                break;
            default:
                Console.WriteLine("Opção inválida! Tente novamente!");
                Console.ReadKey();
                break;
        }
    }
    while (repetir);
}

MenuPrincinpal();