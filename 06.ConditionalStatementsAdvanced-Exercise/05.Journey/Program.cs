// Input

double budget = double.Parse(Console.ReadLine());
string season = Console.ReadLine();

string placeToStay = String.Empty;
double spent = 0;
string destination = String.Empty;

if (budget <= 100)
{
	destination = "Bulgaria";
	switch (season)
	{
		case "summer":
			placeToStay = "Camp";
			spent = budget * 0.30;  
			break;
		case "winter":
            placeToStay = "Hotel";
            spent = budget * 0.70;
            break;
	}
}
else if (budget <= 1000)
{
    destination = "Balkans";
    switch (season)
    {
        case "summer":
            placeToStay = "Camp";
            spent = budget * 0.40;
            break;
        case "winter":
            placeToStay = "Hotel";
            spent = budget * 0.80;
            break;
    }
}
else if (budget > 1000 )
{
    destination = "Europe";
    placeToStay = "Hotel";
    spent = budget * 0.90;
}

Console.WriteLine($"Somewhere in {destination}");
Console.WriteLine($"{placeToStay} - {spent:F2}");