double budget = double.Parse(Console.ReadLine());
string season  = Console.ReadLine();

string location = string.Empty;
string accomodation  = string.Empty;
double priceForStay = 0;

if (budget <= 1000)
{
    accomodation = "Camp";
    if (season == "Summer")
    {
        location = "Alaska";
        priceForStay = budget * 0.65 ;
    }
    else
    {
        location = "Morocco";
        priceForStay = budget * 0.45;
    }
}
else if (budget <= 3000)
{
    accomodation = "Hut";
    if (season == "Summer")
    {
        location = "Alaska";
        priceForStay = budget * 0.80;
    }
    else
    {
        location = "Morocco";
        priceForStay = budget * 0.60;
    }
}
else
{
    accomodation = "Hotel";
    if (season == "Summer")
    {
        location = "Alaska";
    }
    else
    {
        location = "Morocco";
    }
    priceForStay = budget * 0.90;
}

Console.WriteLine($"{location} - {accomodation} - {priceForStay:F2}");