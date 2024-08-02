//Козунак  – 3.20 лв.
//Яйца –  4.35 лв. за кора с 12 яйца
//Курабии – 5.40 лв. за килограм
//Боя за яйца - 0.15 лв. за яйце


int kozunaci = int.Parse(Console.ReadLine());
int koraQica = int.Parse(Console.ReadLine());
int kurabiiKg = int.Parse(Console.ReadLine());

double allQica = koraQica * 12;

double kozunaciPrice = kozunaci * 3.20;
double koraQicaPrice = koraQica * 4.35;
double kurabiiPrice = kurabiiKg * 5.40;
double boqQicaPrice = allQica * 0.15;

double sum = kozunaciPrice + koraQicaPrice + kurabiiPrice + boqQicaPrice;

Console.WriteLine($"{sum:F2}");