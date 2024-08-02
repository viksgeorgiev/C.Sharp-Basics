int rent = int.Parse(Console.ReadLine());

double statuetes  = (double)rent - rent * 0.30;
double cattering = statuetes - statuetes * 0.15;
double sound = cattering / 2;

double sum = rent + statuetes + cattering + sound;

Console.WriteLine($"{sum:F2}");