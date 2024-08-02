string destination = Console.ReadLine();

while (destination != "End")
{
    double budget = double.Parse(Console.ReadLine());
    double money = 0;
    while (money < budget)
    {
        money += double.Parse(Console.ReadLine()); 
    }
    if (money >= budget)
    {
        Console.WriteLine($"Going to {destination}!");
    }
    destination = Console.ReadLine();
}