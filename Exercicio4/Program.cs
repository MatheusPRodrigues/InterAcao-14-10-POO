// 2. Encapsulamento – Conta Bancária

using Exercicio4;

void ExibirDadosDaConta(ContaBancaria conta)
{
    Console.Clear();
    Console.WriteLine("Titular: " + conta.GetTitular());
    Console.WriteLine("Saldo: $" + conta.GetSaldo());
}

void RealizarSaque(ContaBancaria conta)
{
    Console.Clear();
    Console.Write("Digite o valor que deseja sacar: ");
    decimal valor = decimal.Parse(Console.ReadLine());

    if (conta.Sacar(valor))
        Console.WriteLine("Saque realizado com sucesso!");
    else
        Console.WriteLine("Infelizmente não foi possível realizar o saque!");

    Console.ReadKey();
}

void RealizarDeposito(ContaBancaria conta)
{
    Console.Clear();
    Console.Write("Digite o valor de deposito: ");
    decimal valor = decimal.Parse(Console.ReadLine());
    
    if (conta.Depositar(valor))
        Console.WriteLine("Deposito realizado com sucesso!");
    else
        Console.WriteLine("Infelizmente não foi possível realizar o depósito!");

    Console.ReadKey();
}

void Menu()
{
    ContaBancaria conta = new ContaBancaria();

    bool repetir = true;
    do
    {
        ExibirDadosDaConta(conta);
        Console.WriteLine("1 - Sacar");
        Console.WriteLine("2 - Depositar");
        Console.WriteLine("0 - Sair");
        string opcaoDoCliente = Console.ReadLine();

        switch (opcaoDoCliente)
        {
            case "1":
                RealizarSaque(conta);
                break;
            case "2":
                RealizarDeposito(conta);
                break;
            case "0":
                Console.Clear();
                Console.WriteLine("Sistema encerrado!");
                repetir = false;
                break;
            default:
                Console.WriteLine("Opção inválida! Tente novamente!");
                break;
        }
    }
    while (repetir);
}

// Bloco principal
Menu();
