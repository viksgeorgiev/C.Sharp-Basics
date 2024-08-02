
int bitcoinsLeva = int.Parse(Console.ReadLine()) * 1168;
double iuansDollars = double.Parse(Console.ReadLine()) * 0.15;

double iuansToLeva = iuansDollars * 1.76;

double commissionInPercent = double.Parse(Console.ReadLine()) / 100;

double moneyInEuro = (iuansToLeva + bitcoinsLeva) / 1.95;

moneyInEuro -= moneyInEuro * commissionInPercent;

Console.WriteLine($"{moneyInEuro:F2}");