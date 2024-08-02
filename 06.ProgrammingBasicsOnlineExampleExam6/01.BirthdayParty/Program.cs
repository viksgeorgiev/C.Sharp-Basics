double hallRent = double.Parse(Console.ReadLine());


double cake = hallRent * 0.20;
double drinks = cake * 0.55;
double animator = hallRent / 3;

double sum = hallRent + cake + animator + drinks;

Console.WriteLine($"{sum:F1}");