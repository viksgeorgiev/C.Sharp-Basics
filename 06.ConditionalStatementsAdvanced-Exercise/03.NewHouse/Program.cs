// Input

string type = Console.ReadLine();
int quantty = int.Parse(Console.ReadLine());
int budget  = int.Parse(Console.ReadLine());

double price = 0;

switch (type)
{
	case "Roses":
        price = quantty * 5;
        if (quantty > 80 )
        {
            price -= price * 0.10;
        }
		break;
    case "Dahlias":
        price = quantty * 3.80;
        if (quantty > 90)
        {
            price -= price * 0.15;
        }
        break;
    case "Tulips":
        price = quantty * 2.80;
        if (quantty > 80)
        {
            price -= price * 0.15;
        }
        break;
    case "Narcissus":
        price = quantty * 3;
        if (quantty < 120)
        {
            price += price * 0.15;
        }
        break;
    case "Gladiolus":
        price = quantty * 2.50;
        if (quantty < 80)
        {
            price += price * 0.20;
        }
        break;
}

if (budget - price >= 0)
{
    Console.WriteLine($"Hey, you have a great garden with {quantty} {type} and {(budget - price):F2} leva left.");
}
else
{
    Console.WriteLine($"Not enough money, you need {(price - budget):F2} leva more.");
}