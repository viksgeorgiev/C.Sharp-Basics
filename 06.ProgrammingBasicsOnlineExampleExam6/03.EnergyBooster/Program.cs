

string fruit = Console.ReadLine();
string setSize = Console.ReadLine();
int setsOrdered = int.Parse(Console.ReadLine());

double costOfSets = 0;

switch (setSize)
{
	case "small":
		switch (fruit)
		{
			case "Watermelon":
                costOfSets = setsOrdered * (2 * 56);
				break;
            case "Mango":
                costOfSets = setsOrdered * (2 * 36.66);
                break;
            case "Pineapple":
                costOfSets = setsOrdered * (2 * 42.10);
                break;
            case "Raspberry":
                costOfSets = setsOrdered * (2 * 20);
                break;
        }
		break;
    case "big":
        switch (fruit)
        {
            case "Watermelon":
                costOfSets = setsOrdered * (5 * 28.70);
                break;
            case "Mango":
                costOfSets = setsOrdered * (5 * 19.60);
                break;
            case "Pineapple":
                costOfSets = setsOrdered * (5 * 24.80);
                break;
            case "Raspberry":
                costOfSets = setsOrdered * (5 * 15.20);
                break;
        }
        break;

}


if (costOfSets >= 400 && costOfSets <= 1000)
{
    costOfSets -= costOfSets * 0.15;
}
else if (costOfSets > 1000)
{
    costOfSets -= costOfSets * 0.50;
}

Console.WriteLine($"{costOfSets:F2} lv.");