// Типа на горивото – текст с възможности: "Gas", "Gasoline" или "Diesel"
// Количество гориво – реално число в интервала [1.00 … 50.00]
// Притежание на клубна карта – текст с възможности: "Yes" или "No"
// 

string typeOfFuel = Console.ReadLine();
double fuelAmount = double.Parse(Console.ReadLine());
string cardHolder = Console.ReadLine();
double total = 0;

if (cardHolder == "Yes")
{
	switch (typeOfFuel)
	{
		case "Gasoline": total = fuelAmount * 2.04; break;
        case "Diesel": total = fuelAmount * 2.21; break;
        case "Gas": total = fuelAmount * 0.85; break;
	}
}
else
{
    switch (typeOfFuel)
    {
        case "Gasoline": total = fuelAmount * 2.22; break;
        case "Diesel": total = fuelAmount * 2.33; break;
        case "Gas": total = fuelAmount * 0.93; break;
    }
}


if (fuelAmount >= 20 && fuelAmount <= 25)
{
    total -= total * 0.08;
}
else if (fuelAmount > 25)
{
    total -= total * 0.1;
}

Console.WriteLine($"{total:F2} lv.");