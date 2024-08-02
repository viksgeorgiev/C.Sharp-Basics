//1ви ред: X кв.м е лозето – цяло число в интервала [10 … 5000]
//2ри ред: Y грозде за един кв.м – реално число в интервала [0.00 … 10.00]
//3ти ред: Z нужни литри вино – цяло число в интервала [10 … 600]
//4ти ред: брой работници – цяло число в интервала [1 … 20]

int areaX = int.Parse(Console.ReadLine());
double grapesSquaredY = double.Parse(Console.ReadLine());
int litersNeededZ = int.Parse(Console.ReadLine());
int workers =  int.Parse(Console.ReadLine());

double areaForWine = areaX * 0.4;
double grapesKg = grapesSquaredY * areaForWine;
double litersWine = grapesKg / 2.5;
double workersWine = (litersWine - litersNeededZ) / workers;

if (litersNeededZ > litersWine)
{
    Console.WriteLine($"It will be a tough winter! More {Math.Floor(litersNeededZ - litersWine)} liters wine needed.");
}
else
{
    Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(litersWine)} liters.");
    Console.WriteLine($"{Math.Ceiling(litersWine - litersNeededZ)} liters left -> {Math.Ceiling(workersWine)} liters per person.");
}