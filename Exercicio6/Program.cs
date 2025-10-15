// Sistema de Notificações

using Exercicio6;

int InformarNumeroDeNotificoes()
{
    Console.WriteLine("Informe quantas notificações deseja enviar: ");
    int qtdNotificacoes = int.Parse(Console.ReadLine());

    return qtdNotificacoes;
}

char SelecionarNotificacao()
{
    string opcaoDeNotificacao;
    do
    {
        Console.WriteLine("Selecione a notificação que deseja enviar");
        Console.WriteLine("1 - E-Mail");
        Console.WriteLine("2 - SMS");
        Console.WriteLine("3 - PushNotification");
        opcaoDeNotificacao = Console.ReadLine();

    } while (opcaoDeNotificacao != "1" && opcaoDeNotificacao != "2" && opcaoDeNotificacao != "3");

    Console.Clear();
    return char.Parse(opcaoDeNotificacao);
}

Notificacao[] EnviarNotificacoes(Notificacao[] notificacoes)
{
    for (int i = 0; i < notificacoes.Length; i++)
    {
        Console.Clear();

        char opcaoDeNotificacao = SelecionarNotificacao();

        if (opcaoDeNotificacao == '1')
        {
            //Email email = new Email();
            notificacoes[i] = new Email();
        }
        else if (opcaoDeNotificacao == '2')
        {
            //Sms sms = new Sms();
            notificacoes[i] = new Sms();
        }
        else
        {
            //PushNotification pushNotification = new PushNotification();
            notificacoes[i] = new PushNotification();
        }
    }

    return notificacoes;
}

void ExibirNotificacoes(Notificacao[] notificacoes)
{
    Console.Clear();
    Console.WriteLine("==== NOTIFICAÇÕES ENVIADAS ====");
    for (int i = 0; i < notificacoes.Length; i++)
    {
        notificacoes[i].Enviar();
        Console.WriteLine();
    }
    Console.ReadKey();
}

void MenuPrincipal()
{
    Notificacao[] notificacoes = new Notificacao[InformarNumeroDeNotificoes()];
    notificacoes = EnviarNotificacoes(notificacoes);
    ExibirNotificacoes(notificacoes);
}

MenuPrincipal();