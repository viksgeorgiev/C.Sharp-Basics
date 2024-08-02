

int locationsNumber = int.Parse(Console.ReadLine());

for (int i = 1; i <= locationsNumber; i++)
{
    double avgExtraction = double.Parse(Console.ReadLine());
    int daysMiningAtLocation = int.Parse(Console.ReadLine());

    double goldMinedCurrently = 0;

    for (int k = 1; k <= daysMiningAtLocation; k++)
    {
        double goldMined = double.Parse(Console.ReadLine());
        goldMinedCurrently += goldMined;
        
    }

    double avgMinedAtLocation = goldMinedCurrently / daysMiningAtLocation;

    if (avgMinedAtLocation >= avgExtraction)
    {
        Console.WriteLine($"Good job! Average gold per day: {avgMinedAtLocation:F2}.");
    }
    else
    {
        Console.WriteLine($"You need {avgExtraction - avgMinedAtLocation:F2} gold.");
    }
}

