using AgendeDePessoas;

#region "Vetor Pessoa"
//Pessoa[] CadastrarPessoas(Pessoa[] pessoas)
//{
//    for (int i = 0; i < pessoas.Length; i++)
//    {
//        pessoas[i] = new Pessoa();

//        Console.Write($"Insira o nome da {i + 1}º pessoa: ");
//        pessoas[i].setNome(Console.ReadLine());

//        Console.Write($"Insira o sobrenome da {i + 1}º pessoa: ");
//        pessoas[i].setSobrenome(Console.ReadLine());

//        Console.Write($"Insira a idade da {i + 1}º pessoa: ");
//        pessoas[i].setIdade(int.Parse(Console.ReadLine()));

//        Console.Write($"Insira o sexo da {i + 1}º pessoa: ");
//        pessoas[i].setSexo(Console.ReadLine());

//        Console.Write($"Insira a altura da {i + 1}º pessoa: ");
//        pessoas[i].setAltura(double.Parse(Console.ReadLine()));

//        Console.Clear();
//    }

//    return pessoas;
//}

//void ExibirInfoDasPessoas(Pessoa[] pessoas)
//{
//    Console.Clear();
//    Console.WriteLine("===== Pessoas Encontradas =====");
//    for (int i = 0;i < pessoas.Length; i++)
//    {
//        Console.WriteLine(pessoas[i].ExibirInformacoes() + "\n");
//    }
//}

//// Bloco principal
//Pessoa[] pessoas = new Pessoa[3];
//pessoas = CadastrarPessoas(pessoas);

//ExibirInfoDasPessoas(pessoas);
#endregion

Pessoa pessoa = new Pessoa();
pessoa.setNome("Matheus");
pessoa.setSobrenome("Rodrigues");
pessoa.setIdade(20);
pessoa.setSexo("Masculino");
pessoa.setAltura(1.75);
pessoa.setEndereco(new Endereco(
    "Rua A",
    123,
    "Bairro B",
    "12345-678",
    null,
    "Cidade C",
    "Estado D",
    "País E"));

//Console.WriteLine(pessoa.ExibirInformacoes());
pessoa.ExibirInformacoes();