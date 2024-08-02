int clients = int.Parse(Console.ReadLine());

double allMoney = 0;
int counterAllClients = 0;

for (int i = 1; i <= clients; i++)
{
    string input = Console.ReadLine();
	int counterBought = 0;
	double money = 0;
	while (input != "Finish")
	{

		switch (input)
		{
			case "basket":
				money += 1.50;
				counterBought++;
				break;
            case "wreath":
				money += 3.80;
                counterBought++;
                break;
            case "chocolate bunny":
				money += 7;
                counterBought++;
                break;
        }
        input = Console.ReadLine();
    }
	
    if (counterBought % 2 == 0)
	{ money -= money * 0.20; }

    allMoney += money;
    counterAllClients++;

    Console.WriteLine($"You purchased {counterBought} items for {money:F2} leva.");
}

double avgMoney = allMoney / counterAllClients;

Console.WriteLine($"Average bill per client is: {avgMoney:F2} leva.");