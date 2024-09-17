string mensagemDeBoasVindas = "Bem vinda a sua biblioteca de músicas online :)";

//Função
void ExibirLogo()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");    
    Console.WriteLine("\n", mensagemDeBoasVindas);
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("""

        Menu
        1 - Registrar banda
        2 - Mostrar sua lista de bandas
        3 - Avaliar uma banda
        4 - Exibir a média de uma banda
        0 - Para sair
        """);

    Console.Write("Digite sua opção: ");
    //Ler a resposta e armazena
    //! declara que o valor não pode ser nulo
    string respostaMenu = Console.ReadLine()!;
    int respostaMenuNum = int.Parse(respostaMenu);

    switch(respostaMenuNum)
    {
        case 1: 
            RegistrarBanda();
            break;
        case 2: 
            //MostrarBandas();
            break;
        case 3: 
            //AvaliarBanda();
            break;
        case 4: 
            //ExibirMediaBanda();
            break;
     }
}

void RegistrarBanda()
{
    Console.Clear();
    Console.WriteLine("Registro de bandas");
    Console.Write("Digite o nome da banda que você quer registrar: ");
    string nomeBanda = Console.ReadLine()!;
    Console.WriteLine($"A banda {nomeBanda} foi registrado com sucesso!");
    Thread.Sleep(4000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

//Chamando função pra ser executada
ExibirLogo();
ExibirOpcoesDoMenu();
