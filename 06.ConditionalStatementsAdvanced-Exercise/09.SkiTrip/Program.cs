// Input

int stay = int.Parse(Console.ReadLine());
string type = Console.ReadLine();
string rate = Console.ReadLine();

double price = 0;
int nights = stay - 1;


switch (type)
{
	case "room for one person":
        price = nights * 18;
		break;
    case "apartment":
        price = nights * 25;
        if(stay < 10)
        {
            price -= price * 0.30;
        }
        else if (stay >= 10 && stay <= 15)
        {
            price -= price * 0.35;
        }
        else
        {
            price -= price * 0.50;
        }
        break;
    case "president apartment":
        price = nights * 35;
        if (stay < 10)
        {
            price -= price * 0.10;
        }
        else if (stay >= 10 && stay <= 15)
        {
            price -= price * 0.15;
        }
        else
        {
            price -= price * 0.20;
        }
        break;
}

if (rate == "positive")
{
    price += price * 0.25;
}
else
{
    price -= price * 0.10;
}

Console.WriteLine($"{price:F2}");