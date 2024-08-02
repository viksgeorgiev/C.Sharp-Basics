int tournaments = int.Parse(Console.ReadLine());
int startingPoints  = int.Parse(Console.ReadLine());

int pointsWon = 0;
int wonTournaments = 0;

for (int i = 1; i <= tournaments; i++)
{
    string input = Console.ReadLine();

	switch (input)
	{
		case "W":
            startingPoints += 2000;
            pointsWon += 2000;
            wonTournaments++;
            break;
        case "F":
            startingPoints += 1200;
            pointsWon += 1200;
            break;
        case "SF":
            startingPoints += 720;
            pointsWon += 720;
            break;
    }
}

double pointsAverage = (double)pointsWon / tournaments;
double percentWon = ((double)wonTournaments / tournaments) * 100;
Console.WriteLine($"Final points: {startingPoints}");
Console.WriteLine($"Average points: {Math.Floor(pointsAverage)}");
Console.WriteLine($"{percentWon:F2}%");