
string actorName = Console.ReadLine();
double startingPoints = double.Parse(Console.ReadLine());
int assessors = int.Parse(Console.ReadLine());

for (int i = 1; i <= assessors; i++) 
{
    string assessorsName = Console.ReadLine();
    double assessorsPoints = double.Parse(Console.ReadLine());

    startingPoints += assessorsName.Length * assessorsPoints / 2;

    if (startingPoints > 1250.5)
    {
        break;
    }
}

if (startingPoints > 1250.5)
{
    Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {startingPoints:F1}!");
}
else
{
    Console.WriteLine($"Sorry, {actorName} you need {1250.5 - startingPoints:F1} more!");
}