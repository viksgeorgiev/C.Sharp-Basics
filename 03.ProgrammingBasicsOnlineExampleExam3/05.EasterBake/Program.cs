
int kozunaciAmount  = int.Parse(Console.ReadLine());

int sugarUsed = 0;
int flourUsed = 0;

int maxFlour = int.MinValue;
int maxSugar = int.MinValue;


for (int i = 1; i <= kozunaciAmount; i++)
{
    int sugarInput = int.Parse(Console.ReadLine());
    int flourInput = int.Parse(Console.ReadLine());

    sugarUsed += sugarInput;
    flourUsed += flourInput;

    if (maxFlour < flourInput)
    {
        maxFlour = flourInput;
    }

    if (maxSugar < sugarInput)
    {
        maxSugar = sugarInput;
    }
}

double sugarPackets = (double)sugarUsed / 950;
double flourPackets = (double)flourUsed / 750;

Console.WriteLine($"Sugar: {Math.Ceiling(sugarPackets)}");
Console.WriteLine($"Flour: {Math.Ceiling(flourPackets)}");
Console.WriteLine($"Max used flour is {maxFlour} grams, max used sugar is {maxSugar} grams.");