int n = int.Parse(Console.ReadLine());

int p1 = 0;
int p2 = 0;
int p3 = 0;
int p4 = 0;
int p5 = 0;

for (int i = 1; i <= n; i++)
{
    int numberInputed = int.Parse(Console.ReadLine());
    if (numberInputed < 200)
    {
        p1++;
    }
    else if (numberInputed <= 399)
    {
        p2++;
    }
    else if (numberInputed <= 599)
    {
        p3++;
    }
    else if (numberInputed <= 799)
    {
        p4++;
    }
    else if (numberInputed >= 800)
    {
        p5++;
    }
}

Console.WriteLine($"{(Double)p1 / n * 100:F2}%");
Console.WriteLine($"{(Double)p2 / n * 100:F2}%");
Console.WriteLine($"{(Double)p3 / n * 100:F2}%");
Console.WriteLine($"{(Double)p4 / n * 100:F2}%");
Console.WriteLine($"{(Double)p5 / n * 100:F2}%");