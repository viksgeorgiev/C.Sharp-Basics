
double budget = double.Parse(Console.ReadLine());
string season = Console.ReadLine();

string carClass = string.Empty;
string typeOfCar = string.Empty;
double price = 0;

if (budget <= 100)
{
    carClass = "Economy class";
    switch (season)
    {
        case "Summer":
            typeOfCar = "Cabrio";
            price = budget * 0.35;
            break;
        case "Winter":
            typeOfCar = "Jeep";
            price = budget * 0.65;
            break;
    }
}
else if (budget <= 500)
{
    carClass = "Compact class";
    switch (season)
    {
        case "Summer":
            typeOfCar = "Cabrio";
            price = budget * 0.45;
            break;
        case "Winter":
            typeOfCar = "Jeep";
            price = budget * 0.80;
            break;
    }
}
else
{
    carClass = "Luxury class";
    typeOfCar = "Jeep";
    price = budget * 0.90;
}

Console.WriteLine($"{carClass}");
Console.WriteLine($"{typeOfCar} - {price:F2}");