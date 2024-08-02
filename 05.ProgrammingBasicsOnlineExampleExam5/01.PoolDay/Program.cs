
int numberOfPeople = int.Parse(Console.ReadLine());
double taxEntry = double.Parse(Console.ReadLine());
double loungeChairsPrice = double.Parse(Console.ReadLine());
double umbrellaPrice  = double.Parse(Console.ReadLine());

double tax = taxEntry * numberOfPeople;
double numberForUmbrellas = Math.Ceiling(numberOfPeople * 0.50);
double chairsNeeded = Math.Ceiling(numberOfPeople * 0.75);

double umbrellas = numberForUmbrellas * umbrellaPrice;
double loungeChairs = loungeChairsPrice * chairsNeeded;

double sum = tax + umbrellas + loungeChairs;

Console.WriteLine($"{sum:F2} lv.");