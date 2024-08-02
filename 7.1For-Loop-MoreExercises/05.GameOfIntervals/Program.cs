int moves = int.Parse(Console.ReadLine());

double points = 0;

int group1 = 0;
int group2 = 0;
int group3 = 0;
int group4 = 0;
int group5 = 0;
int invalidNumbers = 0;


for (int i = 1; i <= moves; i++)
{
    int input = int.Parse(Console.ReadLine());
    if (input < 0 || input > 50)
    {
        points /= 2;
        invalidNumbers++;
    }
    else if (input <= 9)
    {
        points += input * 0.2;
        group1++;
    }
    else if (input <= 19)
    {
        points += input * 0.3;
        group2++;
    }
    else if (input <= 29)
    {
        points += input * 0.4;
        group3++;
    }
    else if (input <= 39)
    {
        points += 50;
        group4++;
    }
    else if (input <= 50)
    {
        points += 100;
        group5++;
    }
}


Console.WriteLine($"{points:F2}");
Console.WriteLine($"From 0 to 9: {(double)group1 / moves * 100:F2}%");
Console.WriteLine($"From 10 to 19: {(double)group2 / moves * 100:F2}%");
Console.WriteLine($"From 20 to 29: {(double)group3 / moves * 100:F2}%");
Console.WriteLine($"From 30 to 39: {(double)group4 / moves * 100:F2}%");
Console.WriteLine($"From 40 to 50: {(double)group5 / moves * 100:F2}%");
Console.WriteLine($"Invalid numbers: {(double)invalidNumbers / moves * 100:F2}%");
