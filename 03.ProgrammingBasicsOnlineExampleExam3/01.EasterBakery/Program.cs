

double flourPerKgPrice = double.Parse(Console.ReadLine());
double flourKg = double.Parse(Console.ReadLine());
double sugarKg =  double.Parse(Console.ReadLine());
double eggCarton  = double.Parse(Console.ReadLine());
double yeast =  double.Parse(Console.ReadLine());

double flourCost = flourPerKgPrice * flourKg;

double sugarPerKgCost = flourPerKgPrice * 0.75;
double sugarCost = sugarKg * sugarPerKgCost;

double eggPerCartonPrice = flourPerKgPrice + (flourPerKgPrice * 0.10);
double eggCost = eggPerCartonPrice * eggCarton;

double yeastPerCartonPrice = sugarPerKgCost * 0.20;
double yeastCost = yeastPerCartonPrice * yeast;

double sum = flourCost + sugarCost + eggCost + yeastCost;

Console.WriteLine($"{sum:F2}");