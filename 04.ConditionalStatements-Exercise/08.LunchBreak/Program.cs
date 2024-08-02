// Input

string movie = Console.ReadLine();
int episodeLegth = int.Parse(Console.ReadLine());
int breakLength = int.Parse(Console.ReadLine());

double lunchTime = breakLength / 8.0;
double restTime = breakLength / 4.0;

double timeAll = lunchTime + restTime + episodeLegth;

if (timeAll <= breakLength)
{
    Console.WriteLine($"You have enough time to watch {movie} and left with {Math.Ceiling(breakLength-timeAll)} minutes free time.");
}
else
{
    Console.WriteLine($"You don't have enough time to watch {movie}, you need {Math.Ceiling(timeAll - breakLength)} more minutes.");
}