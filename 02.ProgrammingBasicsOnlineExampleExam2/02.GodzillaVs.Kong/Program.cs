double budget = double.Parse(Console.ReadLine());
int extras = int.Parse(Console.ReadLine());
double costumePerExtra  = double.Parse(Console.ReadLine());

double decore = budget * 0.10;
double costumes = extras * costumePerExtra;

if (extras > 150)
{
    costumes -= costumes * 0.10; 
}

double costs = decore + costumes;

if (costs > budget)
{
    Console.WriteLine("Not enough money!");
    Console.WriteLine($"Wingard needs {costs - budget:F2} leva more.");
}
else
{
    Console.WriteLine("Action!" );
    Console.WriteLine($"Wingard starts filming with {budget - costs:F2} leva left.");
}