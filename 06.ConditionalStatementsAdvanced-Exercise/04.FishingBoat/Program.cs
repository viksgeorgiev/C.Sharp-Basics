// Input

int budget = int.Parse(Console.ReadLine());
string season = Console.ReadLine();
int fisherMen =  int.Parse(Console.ReadLine());

double rent = 0;

switch (season)
{
	case "Spring":
        rent = 3000;
		break;
    case "Summer":
    case "Autumn":
        rent = 4200;
        break;
    case "Winter":
        rent = 2600;
        break;
}

if (fisherMen <= 6)
{
    rent -= rent * 0.10;
}
else if (fisherMen >= 7 && fisherMen <= 11)
{
    rent -= rent * 0.15;
}
else if (fisherMen >= 12 )
{
    rent -= rent * 0.25;
}

if (fisherMen % 2 == 0 && season != "Autumn")
{
    rent -= rent * 0.05;
}

if (budget - rent >= 0)
{
    Console.WriteLine($"Yes! You have {(budget - rent):F2} leva left.");
}
else
{
    Console.WriteLine($"Not enough money! You need {(rent - budget):F2} leva.");
}