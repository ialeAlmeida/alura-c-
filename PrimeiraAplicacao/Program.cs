//Jogo proposto no curso

string title = (@"
▄▀█ █▀▄ █ █░█ █ █▄░█ █░█ █▀▀   █▀█   █▄░█ █░█ █▀▄▀█ █▀▀ █▀█ █▀█
█▀█ █▄▀ █ ▀▄▀ █ █░▀█ █▀█ ██▄   █▄█   █░▀█ █▄█ █░▀░█ ██▄ █▀▄ █▄█");

Console.WriteLine(title);

Console.WriteLine("\nSeja bem vinda ao jogo de adivinhação dos números! Você terá que adivnhar um número de 1 a 100. \nFique tranquila, que você só termina quando adivinhar o número :)");

Random r = new Random();
r.Next(100);
int rNum = r.Next(100);

Console.WriteLine("\nDigite um número: ");
int numDigited = int.Parse(Console.ReadLine());


while (rNum != numDigited)
{
    if (numDigited > rNum)
    {
        Console.WriteLine("O número digitado é maior do que o número para adivinhar! Tente novamente :)");
    }
    else if (numDigited < rNum)
    {
        Console.WriteLine("O número digitado é menor do que o número para adivinhar! Tente novamente :)");
    }

    Console.WriteLine("Digite um número: ");
    numDigited = int.Parse(Console.ReadLine());
}

Console.WriteLine($"Parabéns! Você acertou o número {rNum}");