//Função
void ExibirMensagemDeBoasVindas()
{
    Console.WriteLine("𝕧𝕚𝕣𝕥𝕦𝕒𝕝𝕃𝕚𝕓");    
    Console.WriteLine("\nBem vinda a sua biblioteca online :)");
}

void ExibirOpcoesDoMenu()
{
    Console.WriteLine("""

        Menu
        1 - Registrar livro
        2 - Mostrar sua lista de livros
        3 - Avaliar um livro
        4 - Exibir a média de um livro
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
            RegistrarLivro();
            break;
        case 2: 
            MostrarLivros();
            break;
        case 3: 
            AvaliarLivro();
            break;
        case 4: 
            ExibirMedia();
            break;
     }
}

//Chamando função pra ser executada
ExibirMensagemDeBoasVindas();
ExibirOpcoesDoMenu();
