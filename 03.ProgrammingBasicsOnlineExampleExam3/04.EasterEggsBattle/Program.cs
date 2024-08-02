

int playerOne = int.Parse(Console.ReadLine());
int playerTwo = int.Parse(Console.ReadLine());

string winner = Console.ReadLine();

while (winner != "End")
{

    if (winner == "one")
    {
        playerTwo--;
    }
    else if (winner == "two") 
    {
        playerOne--;
    }

    if (playerOne == 0 || playerTwo == 0)
    {
        break;
    }

    winner = Console.ReadLine();
}

if (winner == "End")
{
    Console.WriteLine($"Player one has {playerOne} eggs left.");
    Console.WriteLine($"Player two has {playerTwo} eggs left.");
}
else if (playerOne == 0)
{
    Console.WriteLine($"Player one is out of eggs. Player two has {playerTwo} eggs left.");
}
else if (playerTwo == 0)
{
    Console.WriteLine($"Player two is out of eggs. Player one has {playerOne} eggs left.");
}