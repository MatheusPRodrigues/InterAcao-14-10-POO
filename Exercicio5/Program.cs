// Herança – Sistema de Veículos

using Exercicio5;

int InformarNumeroDeVeiculos()
{
    Console.WriteLine("Informe quantos veículos deseja cadastrar: ");
    int qtdVeiculos = int.Parse(Console.ReadLine());

    return qtdVeiculos;
}

char SelecionarVeiculo()
{
    string opcaoDeVeiculo;
    do
    {
        Console.WriteLine("Selecione o veículo que deseja cadastrar");
        Console.WriteLine("1 - Carro");
        Console.WriteLine("2 - Caminhao");
        Console.WriteLine("3 - Moto");
        opcaoDeVeiculo = Console.ReadLine();

    } while (opcaoDeVeiculo != "1" && opcaoDeVeiculo != "2" && opcaoDeVeiculo != "3");

    Console.Clear();
    return char.Parse(opcaoDeVeiculo);
}

bool TemBau()
{
    string temBau;
    do
    {
        Console.Write("A moto possui baú? (s - sim | n - não): ");;
        temBau = Console.ReadLine();

    } while (temBau != "s" && temBau != "n");

    if (temBau == "s")
        return true;
 
    return false;
}

Carro CadastrarCarro(string marca, string modelo, int ano)
{
    Carro carro = new Carro();

    carro.SetMarca(marca);
    carro.SetModelo(modelo);
    carro.SetAno(ano);

    Console.Write("Digite o número de portas do carro: ");
    carro.SetNumeroDePortas(Convert.ToInt32(Console.ReadLine()));

    return carro;
}

Caminhao CadastrarCaminhao(string marca, string modelo, int ano)
{
    Caminhao caminhao = new Caminhao();

    caminhao.SetMarca(marca);
    caminhao.SetModelo(modelo);
    caminhao.SetAno(ano);

    Console.Write("Digite a carga que o caminhão consegue suportar (em KG): ");
    caminhao.setCapacidadeDeCarga(Convert.ToDouble(Console.ReadLine()));

    return caminhao;
}

Moto CadastrarMoto(string marca, string modelo, int ano)
{
    Moto moto = new Moto();

    moto.SetMarca(marca);
    moto.SetModelo(modelo);
    moto.SetAno(ano);
    moto.SetBau(TemBau());

    return moto;
}

Veiculo[] CadastrarVeiculo(Veiculo[] veiculos)
{
    for (int i = 0; i < veiculos.Length; i++)
    {
        Console.Clear();

        char opcaoDeVeiculo = SelecionarVeiculo();

        Console.Write("Digite a marca do veículo: ");
        string marca = Console.ReadLine();
        
        Console.Write("Digite o modelo do veículo: ");
        string modelo = Console.ReadLine();

        Console.Write("Digite o ano do veículo: ");
        int ano = Convert.ToInt32(Console.ReadLine());

        if (opcaoDeVeiculo == '1')
            veiculos[i] = CadastrarCarro(marca, modelo, ano);
        else if (opcaoDeVeiculo == '2')
            veiculos[i] = CadastrarCaminhao(marca, modelo, ano);
        else
            veiculos[i] = CadastrarMoto(marca, modelo, ano);

    }

    return veiculos;
}

void ExibirInfoDosVeiculos(Veiculo[] veiculos)
{
    Console.Clear();
    Console.WriteLine("====== VEÍCULOS ENCONTRADOS ======");
    for (int i = 0; i < veiculos.Length; i++)
    {
        Console.WriteLine($"Veículo: {veiculos[i].GetType().Name.ToString()}");
        veiculos[i].ExibirInformacoes();
        Console.WriteLine();
    }
    Console.ReadKey();
}

void MenuPrincipal()
{
    Veiculo[] veiculos = new Veiculo[InformarNumeroDeVeiculos()];

    veiculos = CadastrarVeiculo(veiculos);
    ExibirInfoDosVeiculos(veiculos);

    // Talvez eu use
    //bool repetir = true;
    //do
    //{
        
    //}
    //while (repetir);
}

MenuPrincipal();