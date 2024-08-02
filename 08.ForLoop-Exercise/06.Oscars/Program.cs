string actor = Console.ReadLine();
double pointsFromAcademy = double.Parse(Console.ReadLine());
int judges = int.Parse(Console.ReadLine());

for (int i = 1; i <= judges; i++)
{
    string judgeName = Console.ReadLine();
    double score = double.Parse(Console.ReadLine());
    pointsFromAcademy += judgeName.Length * score / 2;

    if (pointsFromAcademy > 1250.5)
    {
        Console.WriteLine($"Congratulations, {actor} got a nominee for leading role with {pointsFromAcademy:F1}!");
        break;
    }
}
if(pointsFromAcademy <= 1250.5)
{
    Console.WriteLine($"Sorry, {actor} you need {1250.5 - pointsFromAcademy:F1} more!");
}
