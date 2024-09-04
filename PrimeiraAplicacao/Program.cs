//Exercícios módulo 02

// --------------------------------------------

int notaMedia = 8;

if (notaMedia >= 5)
{
    Console.WriteLine("Nota suficiente para aprovação");
}

Console.WriteLine("******************************");

List<string> linguagensDeProgramacao = new List<string>();

linguagensDeProgramacao.Add("C#");
linguagensDeProgramacao.Add("Java");
linguagensDeProgramacao.Add("JavaScript");

// --------------------------------------------

Console.WriteLine(linguagensDeProgramacao[0]);

Console.WriteLine("******************************");

List<int> nums = new List<int> { 7, 89, 5, 43, 21, 33, 6, 4, 10 };

Console.WriteLine("Digite um número: ");
int num = int.Parse(Console.ReadLine()!);

if (nums.Contains(num))
{
    Console.WriteLine($"O número digitado é {num} e está na lista");
}
else
{
    Console.WriteLine("Posição inválida");
}

////Declaração de variável string
//string curso = "C#: criando a sua primeira aplicação";
////Imprimir no console
//Console.WriteLine(curso);

//string nome = "Iale";
//string sobrenome = "Almeida";
////Concatenando
//Console.WriteLine("Nome da aluna: " + nome + " " + sobrenome);
////Concatenando 02
//Console.WriteLine($"Olá, {nome}!");
////Concatenando 03
//Console.WriteLine("Olá, {0}!", nome);

// -----------------------------------------------------------------------------------------------------------------------------------

//Função
//void ExibirMensagemDeBoasVindas()
//{
//    //Recursso do @ antes de um texto é chamado de Verbatim Literal. O dev consegue colocar a string no código com a visualização final do produto
//    Console.WriteLine(@"
//░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
//██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
//╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
//░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
//██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
//╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");    
//    Console.WriteLine("\nCurso: C#: criando a sua primeira aplicação");
//}

//void ExibirOpcoesDoMenu()
//{
//    Console.WriteLine("""

//        Menu
//        1 - Registrar banda
//        2 - Mostrar lista de bandas
//        3 - Avaliar uma banda
//        4 - Exibir a média de um a banda
//        0 - Para sair
//        """);

//    Console.Write("Digite sua opção: ");
//    //Ler a resposta e armazena
//    //! declara que o valor não pode ser nulo
//    string respostaMenu = Console.ReadLine()!;
//    int respostaMenuNum = int.Parse(respostaMenu);

//    switch(respostaMenuNum)
//    {
//        case 1: //ewwe
//            break;
//     }
//}

////Chamando função pra ser executada
//ExibirMensagemDeBoasVindas();
//ExibirOpcoesDoMenu();

