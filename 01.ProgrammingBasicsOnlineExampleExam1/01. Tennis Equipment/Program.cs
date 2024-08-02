
double racketPrice = double.Parse(Console.ReadLine());
int racketAmount  = int.Parse(Console.ReadLine());
int sneakersAmount = int.Parse(Console.ReadLine());

double racketTotal = racketPrice * racketAmount;

double sneakerPrice = racketPrice / 6;

double sneakersTotal = sneakerPrice * sneakersAmount;

double othersTotal = (sneakersTotal + racketTotal) * 0.20;

double allTotal = racketTotal + sneakersTotal + othersTotal;

Console.WriteLine($"Price to be paid by Djokovic {Math.Floor(allTotal / 8)}");
Console.WriteLine($"Price to be paid by sponsors {Math.Ceiling((7 * allTotal) / 8)}");
