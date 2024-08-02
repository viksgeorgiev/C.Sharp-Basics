// Input

string product = Console.ReadLine();
string town  = Console.ReadLine();
double quantity = double.Parse(Console.ReadLine());

double price = 0;

switch (product)
{
	case "coffee":
        if (town == "Sofia")
        {
            price = quantity * 0.50;
        }
        else if (town == "Plovdiv")
        {
            price = quantity * 0.40;
        }
        else
        {
            price = quantity * 0.45;
        }
        break;
    case "water":
        if (town == "Sofia")
        {
            price = quantity * 0.80;
        }
        else if (town == "Plovdiv")
        {
            price = quantity * 0.70;
        }
        else
        {
            price = quantity * 0.70;
        }
        break;
    case "beer":
        if (town == "Sofia")
        {
            price = quantity * 1.20;
        }
        else if (town == "Plovdiv")
        {
            price = quantity * 1.15;
        }
        else
        {
            price = quantity * 1.10;
        }
        break;
    case "sweets":
        if (town == "Sofia")
        {
            price = quantity * 1.45;
        }
        else if (town == "Plovdiv")
        {
            price = quantity * 1.30;
        }
        else
        {
            price = quantity * 1.35;
        }
        break;
            case "peanuts":
        if (town == "Sofia")
        {
            price = quantity * 1.60;
        }
        else if (town == "Plovdiv")
        {
            price = quantity * 1.50;
        }
        else
        {
            price = quantity * 1.55;
        }
        break;
 }

Console.WriteLine(price);