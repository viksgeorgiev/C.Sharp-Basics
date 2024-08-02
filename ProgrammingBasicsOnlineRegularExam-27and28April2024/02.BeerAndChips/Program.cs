
string fanName = Console.ReadLine();
double budget = double.Parse(Console.ReadLine());
int beerBottles  = int.Parse(Console.ReadLine());
int chipsPackets  = int.Parse(Console.ReadLine());

double costOfBeers = (double)beerBottles * 1.20;
double priceOfChips = costOfBeers * 0.45;
double costOfChips = Math.Ceiling(priceOfChips * chipsPackets);

double allCosts = costOfBeers + costOfChips;

if ( allCosts <= budget)
{
    Console.WriteLine($"{fanName} bought a snack and has {budget - allCosts:F2} leva left.");
}
else if(allCosts > budget)
{
    Console.WriteLine($"{fanName} needs {allCosts - budget:F2} more leva!");
}

