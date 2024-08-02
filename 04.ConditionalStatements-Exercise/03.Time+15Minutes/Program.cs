// Input

int hours = int.Parse(Console.ReadLine());
int minutes = int.Parse(Console.ReadLine());

minutes += (hours * 60) + 15;


if (minutes / 60 < 24)
{
    int hoursToPrint = minutes / 60;
    int minutesToPrint = minutes % 60;
    Console.WriteLine($"{hoursToPrint}:{minutesToPrint:d2}");
}
else if (minutes / 60 >= 24)
{
    int hoursToPrint = minutes / 60;
    int minutesToPrint = minutes % 60;
    

    Console.WriteLine($"0:{minutesToPrint:d2}");
}