using System.Diagnostics;

int kozunaciQuantity = int.Parse(Console.ReadLine());

int maxPoints = int.MinValue;
string chefMaxName = String.Empty;


for (int i = 1; i <= kozunaciQuantity; i++)
{
    string chefName = Console.ReadLine();
    string pointsInput = Console.ReadLine();
    int sumPoints = 0;
    while (pointsInput != "Stop")
    {
        int pointsGiven = int.Parse(pointsInput);
        sumPoints += pointsGiven;
        pointsInput = Console.ReadLine();
    }
    Console.WriteLine($"{chefName} has {sumPoints} points.");
    if (sumPoints > maxPoints)
    {
        maxPoints = sumPoints;
        chefMaxName = chefName;
        Console.WriteLine($"{chefMaxName} is the new number 1!");
    }
}

Console.WriteLine($"{chefMaxName} won competition with {maxPoints} points!");
