int cakeSize = int.Parse(Console.ReadLine()) * int.Parse(Console.ReadLine());
string input = Console.ReadLine();
while (true)
{
    if (input == "STOP")
    {
        Console.WriteLine($"{cakeSize} pieces are left.");
        break;
    }
    else if (cakeSize > 0)
    {
        int pieces = int.Parse(input);
        cakeSize -= pieces;       
    }
    if (cakeSize < 0)
    {
        Console.WriteLine($"No more cake left! You need {Math.Abs(cakeSize)} pieces more.");
        break;
    }
    input = Console.ReadLine();
}