//Função
void ExibirMensagemDeBoasVindas()
{
    //Recursso do @ antes de um texto é chamado de Verbatim Literal. O dev consegue colocar a string no código com a visualização final do produto
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");    
    Console.WriteLine("\nCurso: C#: criando a sua primeira aplicação");
}

void ExibirOpcoesDoMenu()
{
    Console.WriteLine("""

        Menu
        1 - Registrar banda
        2 - Mostrar lista de bandas
        3 - Avaliar uma banda
        4 - Exibir a média de um a banda
        0 - Para sair
        """);

    Console.Write("Digite sua opção: ");
    //Ler a resposta e armazena
    //! declara que o valor não pode ser nulo
    string respostaMenu = Console.ReadLine()!;
    int respostaMenuNum = int.Parse(respostaMenu);

    switch(respostaMenuNum)
    {
        case 1: //ewwe
            break;
     }
}

//Chamando função pra ser executada
ExibirMensagemDeBoasVindas();
ExibirOpcoesDoMenu();
