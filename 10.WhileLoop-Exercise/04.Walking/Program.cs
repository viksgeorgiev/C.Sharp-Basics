string input = Console.ReadLine();
int steps = 0;


while (input != "Going home")
{
    steps += int.Parse(input);
    if (steps < 10000)
    {
        input = Console.ReadLine();
    }
    else
    {
        Console.WriteLine("Goal reached! Good job!");
        Console.WriteLine($"{steps - 10000} steps over the goal!");
        break;
    }
}

if(input == "Going home")
{
    int moreSteps = int.Parse(Console.ReadLine());
    steps += moreSteps;
    if (steps < 10000)
    {
        Console.WriteLine($"{10000 - steps} more steps to reach goal.");
    }
    else
    {
        Console.WriteLine("Goal reached! Good job!");
        Console.WriteLine($"{steps - 10000} steps over the goal!");
    }
}
