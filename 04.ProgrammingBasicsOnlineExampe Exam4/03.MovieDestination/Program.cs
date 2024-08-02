
double budget = double.Parse(Console.ReadLine());
string destination = Console.ReadLine();
string season = Console.ReadLine();
int daysCount = int.Parse(Console.ReadLine());

double cost = 0;

switch (season)
{
    case "Winter":
        switch (destination)
        {
            case "Dubai":
                cost = daysCount * 45000;
                break;
            case "Sofia":
                cost = daysCount * 17000;
                break;
            case "London":
                cost = daysCount * 24000;
                break;
        }
        break;
    case "Summer":
        switch (destination)
        {
            case "Dubai":
                cost = daysCount * 40000;
                break;
            case "Sofia":
                cost = daysCount * 12500;
                break;
            case "London":
                cost = daysCount * 20250;
                break;
        }
        break;
}

if (destination == "Dubai")
{
    cost -= cost * 0.30;
}
else if (destination == "Sofia")
{
    cost += cost * 0.25;
}

if (budget >= cost)
{
    Console.WriteLine($"The budget for the movie is enough! We have {budget - cost:F2} leva left!");
}
else
{
    Console.WriteLine($"The director needs {cost - budget:F2} leva more!");
}