int salesExpected = int.Parse(Console.ReadLine());
string input  = Console.ReadLine();

int counter = 1;
double card = 0;
int cardCounter = 0;
double cash = 0;
int cashCounter = 0;
int transaction = 0;

while (input != "End")
{
    transaction = int.Parse(input);
    if ((counter % 2 == 1) && transaction <= 100)
    {
        cash += transaction;
        cashCounter++;
        Console.WriteLine("Product sold!");
    }
    else if ((counter % 2 == 0) && transaction > 10)
    {
        card += transaction;
        cardCounter++;
        Console.WriteLine("Product sold!");
    }
    else
    {
        Console.WriteLine("Error in transaction!");
    }

    if ((card + cash) >= salesExpected) 
    {
        Console.WriteLine($"Average CS: {(cash / cardCounter):F2}");
        Console.WriteLine($"Average CC: {(card / cardCounter):F2}");
        break;
    }
    counter++;
    input = Console.ReadLine();
}

if (input == "End")
{
    Console.WriteLine("Failed to collect required money for charity.");
}
	
