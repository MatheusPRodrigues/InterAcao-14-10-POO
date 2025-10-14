// Sistema de Gerenciamento de Funcionários

using Exercicio1;

int InformarNumeroDeFuncionarios()
{
    Console.WriteLine("Informe quantos funcionários quer cadastrar: ");
    int qtdFuncionarios = int.Parse(Console.ReadLine());

    return qtdFuncionarios;
}

char SelecionarFuncionario()
{
    string opcaoDeFuncionario;
    do
    {
        Console.Write("Deseja cadastrar um funcionário (1 - CLT) ou (2 - PJ): ");
        opcaoDeFuncionario = Console.ReadLine();

    } while (opcaoDeFuncionario != "1" && opcaoDeFuncionario != "2");

    Console.Clear();
    return char.Parse(opcaoDeFuncionario);
}

FuncionarioCLT CadastrarFuncionarioClt()
{
    FuncionarioCLT funcionario = new FuncionarioCLT();

    Console.Write("Digite o nome do funcionário: ");
    funcionario.SetNome(Console.ReadLine());

    Console.Write("Digite o salário base do funcionário: ");
    funcionario.SetSalarioBase(double.Parse(Console.ReadLine()));

    Console.Write("Digite o bônus do funcionário: ");
    funcionario.SetBonus(double.Parse(Console.ReadLine()));

    return funcionario;
}

FuncionarioPJ CadastrarFuncionarioPj()
{
    FuncionarioPJ funcionario = new FuncionarioPJ();

    Console.Write("Digite o nome do funcionário: ");
    funcionario.SetNome(Console.ReadLine());

    Console.Write("Digite as horas trabalhadas pelo funcionário: ");
    funcionario.SetHorasTrabalhadas(int.Parse(Console.ReadLine()));

    Console.Write("Digite o valor por hora do funcionário: ");
    funcionario.SetValorHora(double.Parse(Console.ReadLine()));

    return funcionario;
}

Funcionario[] CadastrarFuncionarios(Funcionario[] funcionarios)
{
    for (int i = 0; i < funcionarios.Length; i++)
    {
        Console.Clear();
 
        if (SelecionarFuncionario() == '1')
            funcionarios[i] = CadastrarFuncionarioClt();
        else 
            funcionarios[i] = CadastrarFuncionarioPj();

    }
    return funcionarios;
}

void ExibirInfoDosFuncionarios(Funcionario[] funcionarios)
{
    Console.Clear();
    Console.WriteLine("==== FUNCIONARIOS CADASTRADOS ====");
    for (int i = 0; i < funcionarios.Length; i++)
    {
        funcionarios[i].ExibirInfo();
        Console.WriteLine();
    }
}

Funcionario[] funcionarios;
funcionarios = new Funcionario[InformarNumeroDeFuncionarios()];

funcionarios = CadastrarFuncionarios(funcionarios);
ExibirInfoDosFuncionarios(funcionarios);