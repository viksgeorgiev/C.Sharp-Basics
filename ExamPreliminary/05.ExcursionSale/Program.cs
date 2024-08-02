//От конзолата първоначално се четат 2 реда:
//1.Брой екскурзии за море – цяло число в интервала [1… 500]
//2.Брой екскурзии за планина – цяло число в интервала [1… 500]
//След това се чете по един ред до получаване на команда "Stop" или докато фирмата не продаде всички пакети:
//•	Име на пакет – текст с възможности "sea" или "mountain"

int seaExcursions  = int.Parse(Console.ReadLine());
int mountainExcursions = int.Parse(Console.ReadLine());

string packetName = Console.ReadLine();

double profit = 0;


while (packetName != "Stop")
{
	switch (packetName)
	{
		case "sea":
			if (seaExcursions > 0)
			{
				seaExcursions--;
				profit += 680;
			}
			break;
        case "mountain":
            if (mountainExcursions > 0)
            {
                mountainExcursions--;
                profit += 499;
            }
            break;
    }
	if (seaExcursions == 0 && mountainExcursions == 0)
	{ break; }

	packetName = Console.ReadLine();
}

if (seaExcursions == 0 && mountainExcursions == 0)
{
    Console.WriteLine(" Good job! Everything is sold.");
}

Console.WriteLine($"Profit: {profit} leva.");