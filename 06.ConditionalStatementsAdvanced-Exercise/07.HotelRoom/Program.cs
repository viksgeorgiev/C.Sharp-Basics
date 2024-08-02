// Input

string month = Console.ReadLine();
int stay = int.Parse(Console.ReadLine());

double priceStudio = 0;
double priceApart = 0;

if (month == "May" || month == "October")
{
    priceStudio = stay * 50;
    priceApart = stay * 65;
}
else if (month == "June" || month == "September")
{
    priceStudio = stay * 75.20;
    priceApart = stay * 68.70;
}
else if (month == "July" || month == "August")
{
    priceStudio = stay * 76;
    priceApart = stay * 77;
}

if((stay > 7 && stay <= 14 ) && (month == "May" || month == "October"))
{
    priceStudio -= priceStudio * 0.05;
}
else if (stay > 14 && (month == "May" || month == "October"))
{
    priceStudio -= priceStudio * 0.30;
}
else if (stay > 14 && (month == "June" || month == "September"))
{
    priceStudio -= priceStudio * 0.20;
}

if (stay > 14 )
{
    priceApart -= priceApart * 0.10;
}

Console.WriteLine($"Apartment: {priceApart:F2} lv.");
Console.WriteLine($"Studio: {priceStudio:F2} lv.");