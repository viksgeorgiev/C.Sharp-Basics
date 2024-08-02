string series = Console.ReadLine();
int seasons = int.Parse(Console.ReadLine());
int episodes = int.Parse(Console.ReadLine());
double length  = double.Parse(Console.ReadLine());

double advertsTime = length * 0.20;
double episodeWithAdvertsTime = length + advertsTime;

double extraTime = seasons * 10;

double total = episodeWithAdvertsTime * episodes * seasons + extraTime;

Console.WriteLine($"Total time needed to watch the {series} series is {Math.Floor(total)} minutes.");