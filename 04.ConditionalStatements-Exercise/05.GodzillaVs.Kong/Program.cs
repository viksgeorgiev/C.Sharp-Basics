// Input

double budget = double.Parse(Console.ReadLine());
int extras = int.Parse(Console.ReadLine());
double costumePrice = double.Parse(Console.ReadLine());

double decor = budget * 0.1;
double costumes = costumePrice * extras;

if (extras > 150)
{
    costumes -= costumes * 0.10;
}

double moneyForBudget = decor + costumes;

if (budget < moneyForBudget)
{ 
    Console.WriteLine("Not enough money!");
    Console.WriteLine($"Wingard needs {(moneyForBudget - budget):f2} leva more.");
}
else
{
    Console.WriteLine("Action!");
    Console.WriteLine($"Wingard starts filming with {(budget - moneyForBudget):f2} leva left.");
}