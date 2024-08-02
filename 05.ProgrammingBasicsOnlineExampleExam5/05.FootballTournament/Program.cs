
string teamName = Console.ReadLine();
int matches = int.Parse(Console.ReadLine());

int counterW = 0;
int counterD = 0;
int counterL = 0;
int pointsWon = 0;

if (matches == 0)
{ Console.WriteLine($"{teamName} hasn't played any games during this season.");   
}
else
{
    for (int i = 1; i <= matches; i++)
    {
        string resultOfGame = Console.ReadLine();

        switch (resultOfGame)
        {
            case "W":
                pointsWon += 3;
                counterW++;
                break;
            case "D":
                pointsWon += 1;
                counterD++;
                break;
            case "L":
                counterL++;
                break;
        }
    }

    double gamesWon = (double)counterW / matches * 100;

    Console.WriteLine($"{teamName} has won {pointsWon} points during this season.");
    Console.WriteLine($"Total stats:");
    Console.WriteLine($"## W: {counterW}");
    Console.WriteLine($"## D: {counterD}" );
    Console.WriteLine($"## L: {counterL}" );
    Console.WriteLine($"Win rate: {gamesWon:F2}%");
}
