

double wantedProfit = double.Parse(Console.ReadLine());

string cocktailName = Console.ReadLine();
int cocktailNumber = int.Parse(Console.ReadLine());

double profit = 0;

while(true)
{
    double currentOrder = cocktailName.Length * cocktailNumber;

    if (currentOrder % 2 == 1)
    {
        currentOrder -= currentOrder * 0.25;
    }

    profit += currentOrder;

    if (profit >= wantedProfit)
    {
        Console.WriteLine("Target acquired.");
        break;
    }

    cocktailName = Console.ReadLine();

    if (cocktailName == "Party!")
    {
        Console.WriteLine($"We need {wantedProfit - profit:F2} leva more.");
        break;
    }
   
    cocktailNumber = int.Parse(Console.ReadLine());
    
}

Console.WriteLine($"Club income - {profit:F2} leva.");