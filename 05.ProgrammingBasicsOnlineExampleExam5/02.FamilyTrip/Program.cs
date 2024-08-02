
double budget = double.Parse(Console.ReadLine());
int nights  = int.Parse(Console.ReadLine());
double pricePerNight = double.Parse(Console.ReadLine());
int percentForExpenditures  = int.Parse(Console.ReadLine());

if (nights > 7)
{
    pricePerNight -= pricePerNight * 0.05;
}

double cost = nights * pricePerNight;
double percents = (double)percentForExpenditures / 100;
cost += budget * percents;

if (cost <= budget)
{
    Console.WriteLine($"Ivanovi will be left with {budget - cost:F2} leva after vacation.");
}
else
{
    Console.WriteLine($"{cost - budget:F2} leva needed.");
}
