
int videoCardPrice = int.Parse(Console.ReadLine());
int adapterPrice  = int.Parse(Console.ReadLine());
double powerPrice  = double.Parse(Console.ReadLine());
double profitPerCard  = double.Parse(Console.ReadLine());

int videoCardsCost = 13 * videoCardPrice;
int adapterCardsCost = 13 * adapterPrice;

int pcCost = videoCardsCost + adapterCardsCost + 1000;

double profitPerDay = 13 * (profitPerCard - powerPrice);

Console.WriteLine(pcCost);
Console.WriteLine($"{Math.Ceiling(pcCost / profitPerDay)}");