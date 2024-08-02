double costOfHoliday = double.Parse(Console.ReadLine());
double startMoney = double.Parse(Console.ReadLine());
int daysCounter = 0;
int spendingDays = 0;


while (true)
{
    string moneyAction = Console.ReadLine();
    double moneyMovement = double.Parse(Console.ReadLine());
    daysCounter++;

    if (moneyAction == "spend")
    {
        startMoney -= moneyMovement;
        if (startMoney < 0) 
        {  
            startMoney = 0; 
        }
        spendingDays++;
    }
    else
    {
        startMoney += moneyMovement;
        spendingDays = 0;
    }

    if (spendingDays == 5)
    {
        Console.WriteLine("You can't save the money.");
        Console.WriteLine($"{daysCounter}");
        break;
    }
    else if (startMoney >= costOfHoliday)
    {
        Console.WriteLine($"You saved the money for {daysCounter} days.");
        break;
    }
}