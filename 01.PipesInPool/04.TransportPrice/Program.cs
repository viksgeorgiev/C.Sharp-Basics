int kilometers = int.Parse(Console.ReadLine());
string timeOfDay =  Console.ReadLine();
double fare = 0;

if (kilometers >= 100)
{
    fare = kilometers * 0.06;
}
else if (kilometers >= 20)
{
    fare = kilometers * 0.09;
}
else
{
    switch (timeOfDay)
    {
        case "day":
            fare = 0.70 + (kilometers * 0.79);
            break;
        case "night":
            fare = 0.70 + (kilometers * 0.90);
            break;
    }
}
Console.WriteLine($"{fare:F2}");