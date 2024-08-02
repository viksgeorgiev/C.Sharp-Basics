//	W - ако е победител получава 2000 точки
//	F - ако е финалист получава 1200 точки
//	SF - ако е полуфиналист получава 720 точки

int tournaments = int.Parse(Console.ReadLine());
int pointsStarting = int.Parse(Console.ReadLine());
int won = 0;
int pointsEarned = 0;

for (int i = 1; i <= tournaments; i++)
{
    string stageAchieved = Console.ReadLine();
	switch (stageAchieved)
	{
		case "W":
			pointsStarting += 2000;
            won++;
            pointsEarned += 2000;
			break;
        case "F":
            pointsStarting += 1200;
            pointsEarned += 1200;
            break;
        case "SF":
            pointsStarting += 720;
            pointsEarned += 720;
            break;
    }
}

Console.WriteLine($"Final points: {pointsStarting}");
Console.WriteLine($"Average points: {(pointsEarned / tournaments)}");
Console.WriteLine($"{(double)won / tournaments * 100:F2}%");

