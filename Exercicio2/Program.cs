// Sistema de Animais no Zoológico

using Exercicio2;

int InformarNumeroDeAnimais()
{
    Console.WriteLine("Informe quantos animais quer cadastrar: ");
    int qtdDeAnimais = int.Parse(Console.ReadLine());

    return qtdDeAnimais;
}

char SelecionarAnimal()
{
    string opcaoDeAnimal;
    do
    {
        Console.Write("Selecione o animal para cadastrar (1 -Cachorro | 2 - Gato | 3 - Leão): ");
        opcaoDeAnimal = Console.ReadLine();

    } while (opcaoDeAnimal != "1" && opcaoDeAnimal != "2" && opcaoDeAnimal != "3");

    Console.Clear();
    return char.Parse(opcaoDeAnimal);
}

Cachorro CadastrarCachorro(string nome, int idade)
{
    Cachorro cachorro = new Cachorro();
    cachorro.SetNome(nome);
    cachorro.SetIdade(idade);
    return cachorro;
}

Gato CadastrarGato(string nome, int idade)
{
    Gato gato = new Gato();
    gato.SetNome(nome);
    gato.SetIdade(idade);
    return gato;
}

Leao CadastrarLeao(string nome, int idade)
{
    Leao leao = new Leao();
    leao.SetNome(nome);
    leao.SetIdade(idade);
    return leao;
}

Animal[] CadastrarAnimais(Animal[] animais)
{
    for (int i = 0; i < animais.Length; i++)
    {
        Console.Clear();

        char opcaoDeAnimal = SelecionarAnimal();

        Console.Write("Digite o nome do animal: ");
        string nome = Console.ReadLine();

        Console.Write("Digite a idade do animal: ");
        int idade = int.Parse(Console.ReadLine());

        if (opcaoDeAnimal == '1')
            animais[i] = CadastrarCachorro(nome, idade);
        else if (opcaoDeAnimal == '2')
            animais[i] = CadastrarGato(nome, idade);
        else
            animais[i] = CadastrarLeao(nome, idade);
    }
    return animais;
}

void ExibirAnimais(Animal[] animais)
{
    Console.Clear();
    Console.WriteLine("===== ANIMAIS CADASTRADOS =====");
    for (int i = 0; i < animais.Length; i++)
    {
        Console.WriteLine(animais[i].ToString());
        animais[i].EmitirSom();
        Console.WriteLine();
    }
}

Animal[] animais = new Animal[InformarNumeroDeAnimais()];
animais = CadastrarAnimais(animais);
ExibirAnimais(animais);