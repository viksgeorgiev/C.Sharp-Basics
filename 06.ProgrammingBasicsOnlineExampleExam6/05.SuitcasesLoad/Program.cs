
double capacity = double.Parse(Console.ReadLine());

string input  = Console.ReadLine();
int counterSuitcases = 0;
int suitcasesLoaded = 1;
bool isFull = false;

while (input != "End")
{
    double suitcaseVolume = double.Parse(input);

    if (suitcasesLoaded % 3 == 0)
    { suitcaseVolume += suitcaseVolume * 0.10; }

    if (suitcaseVolume >= capacity)
    {
        isFull = true;
        break;
    }

    capacity -= suitcaseVolume;

    counterSuitcases++;
    suitcasesLoaded++;
    input = Console.ReadLine();
}

if (isFull == true)
{
    Console.WriteLine("No more space!");
}
else
{
    Console.WriteLine("Congratulations! All suitcases are loaded!");
}

Console.WriteLine($"Statistic: {counterSuitcases} suitcases loaded.");