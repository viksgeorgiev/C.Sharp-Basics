string tournament = string.Empty;
int matchesPlayed = 0;
int pointsDesi = 0;
int pointsOpponents = 0;

int gameCounter =0;
int counterWon = 0;
int counterLost = 0;

while(tournament != "End of tournaments")
{
    tournament = Console.ReadLine();
    if (tournament == "End of tournaments")
    { continue; }

    matchesPlayed = int.Parse(Console.ReadLine());

    for (int i = 1; i <= matchesPlayed; i++)
    {
        pointsDesi = int.Parse(Console.ReadLine());
        pointsOpponents = int.Parse(Console.ReadLine());
        gameCounter++;

        if (pointsDesi > pointsOpponents)
        {
            counterWon++;
            Console.WriteLine($"Game {i} of tournament {tournament}: win with {pointsDesi - pointsOpponents} points.");
        }
        else 
        {
            counterLost++;
            Console.WriteLine($"Game {i} of tournament {tournament}: lost with {pointsOpponents - pointsDesi} points.");
        }
    }
}

double percentWon = (double)counterWon / gameCounter * 100;
double percentLost = (double)counterLost / gameCounter * 100;

Console.WriteLine($"{percentWon:F2}% matches win");
Console.WriteLine($"{percentLost:F2}% matches lost");