int eggsInStore = int.Parse(Console.ReadLine());

string command = Console.ReadLine();
int eggs = int.Parse(Console.ReadLine());

bool isOver = false;
int eggsSold = 0;

while (true)
{
	switch (command)
	{
		case "Buy":
			if (eggs > eggsInStore)
			{
				isOver = true;
				break;
			}
			else
			{
				eggsInStore -= eggs;
				eggsSold += eggs;
			}
			break;
        case "Fill":
			eggsInStore += eggs; 
            break;
    }
	if(isOver == true)
	{
		break;
	}
	command = Console.ReadLine();
	if (command == "Close")
	{ break; }
	eggs = int.Parse(Console.ReadLine());
}

if (command == "Close")
{
    Console.WriteLine($"Store is closed!");
	Console.WriteLine($"{eggsSold} eggs sold.");
}
else
{
    Console.WriteLine($"Not enough eggs in store!");
    Console.WriteLine($"You can buy only {eggsInStore}.");
}