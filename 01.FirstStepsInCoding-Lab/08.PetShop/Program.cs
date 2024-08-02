// Input

double packsDog = double.Parse(Console.ReadLine());
double packsCat = double.Parse(Console.ReadLine());

// Calculations

double priceDogs = packsDog * 2.50;
double priceCats = packsCat * 4;
double costAll = priceDogs + priceCats;

// Output

Console.WriteLine($"{costAll} lv.");
