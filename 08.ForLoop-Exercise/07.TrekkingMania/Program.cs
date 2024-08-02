
int groups = int.Parse(Console.ReadLine());

int g1 = 0;
int g2 = 0;
int g3 = 0;
int g4 = 0;
int g5 = 0;
int allGroups = 0;

for (int i = 1; i <= groups; i++)
{
    int groupSize = int.Parse(Console.ReadLine());
    if (groupSize <= 5)
    {
        g1 += groupSize;
        allGroups += groupSize;
    }
    else if (groupSize <= 12)
    {
         g2 += groupSize;
        allGroups += groupSize;
    }
    else if (groupSize <= 25)
    {
        g3 += groupSize;
        allGroups += groupSize;
    }
    else if (groupSize <= 40)
    {
        g4 += groupSize;
        allGroups += groupSize;
    }
    else if (groupSize >= 41)
    {
        g5 += groupSize;
        allGroups += groupSize;
    }
}
Console.WriteLine($"{((double)g1 / allGroups * 100):F2}%");
Console.WriteLine($"{((double)g2 / allGroups * 100):F2}%");
Console.WriteLine($"{((double)g3 / allGroups * 100):F2}%");
Console.WriteLine($"{((double)g4 / allGroups * 100):F2}%");
Console.WriteLine($"{((double)g5 / allGroups * 100):F2}%");