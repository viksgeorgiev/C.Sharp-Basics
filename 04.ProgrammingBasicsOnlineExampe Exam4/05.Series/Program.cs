
double budget = double.Parse(Console.ReadLine());
int numberOfSeries  = int.Parse(Console.ReadLine());

double priceForAll = 0;

for (int i = 1; i <= numberOfSeries; i++)
{
    string seriesName = Console.ReadLine();
    double priceForSeries = double.Parse(Console.ReadLine());

    switch (seriesName)
    {
        case "Thrones":
            priceForSeries -= priceForSeries * 0.50;
            break;
        case "Lucifer":
            priceForSeries -= priceForSeries * 0.40;
            break;
        case "Protector":
            priceForSeries -= priceForSeries * 0.30;
            break;
        case "TotalDrama":
            priceForSeries -= priceForSeries * 0.20;
            break;
        case "Area":
            priceForSeries -= priceForSeries * 0.10;
            break;
    }
    priceForAll += priceForSeries;
}

if (budget >= priceForAll)
{
    Console.WriteLine($"You bought all the series and left with {budget - priceForAll:F2} lv.");
}
else
{
    Console.WriteLine($"You need {priceForAll - budget:F2} lv. more to buy the series!");
}