

int customers = int.Parse(Console.ReadLine());
string season  = Console.ReadLine();

double price = 0;

if (customers <= 5)
{
	switch (season)
	{
		case "spring":
            price = customers * 50.00;
			break;
        case "summer":
            price = customers * 48.50;
            break;
        case "autumn":
            price = customers * 60.00;
            break;
        case "winter":
            price = customers * 86.00;
            break;
    }
}
else
{
    switch (season)
    {
        case "spring":
            price = customers * 48.00;
            break;
        case "summer":
            price = customers * 45.00;
            break;
        case "autumn":
            price = customers * 49.50;
            break;
        case "winter":
            price = customers * 85.00;
            break;
    }
}

if (season == "summer")
{
    price -= price * 0.15;
}
else if (season == "winter")
{
    price += price * 0.08;
}

Console.WriteLine($"{price:F2} leva.");