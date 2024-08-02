
string typeOfCake = Console.ReadLine();
int cakeNumber = int.Parse(Console.ReadLine());
int dayOfDecember  = int.Parse(Console.ReadLine());

double costOfPastry = 0;

switch (typeOfCake)
{
	case "Cake":
        if (dayOfDecember <= 15)
        {
            costOfPastry = 24 * cakeNumber;
        }
        else if (dayOfDecember > 15)
        {
            costOfPastry = 28.70 * cakeNumber;
        }
		break;
    case "Souffle":
        if (dayOfDecember <= 15)
        {
            costOfPastry = 6.66 * cakeNumber;
        }
        else if (dayOfDecember > 15)
        {
            costOfPastry = 9.80 * cakeNumber;
        }
        break;
    case "Baklava":
        if (dayOfDecember <= 15)
        {
            costOfPastry = 12.60 * cakeNumber;
        }
        else if (dayOfDecember > 15)
        {
            costOfPastry = 16.98 * cakeNumber;
        }
        break;
}

if(dayOfDecember <= 22)
{
    if (costOfPastry >= 100 && costOfPastry <= 200)
    {
        costOfPastry -= costOfPastry * 0.15;
    }
    if(costOfPastry > 200)
    {
        costOfPastry -= costOfPastry * 0.25;
    }
    if(dayOfDecember <= 15)
    {
        costOfPastry -= costOfPastry * 0.10;
    }
}

Console.WriteLine($"{costOfPastry:F2}");
