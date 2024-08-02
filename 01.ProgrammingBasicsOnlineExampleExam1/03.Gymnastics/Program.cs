string country = Console.ReadLine();
string routine  = Console.ReadLine();

double difficulty = 0.0;
double performanmce = 0.0;

switch (country)
{
	case "Russia":
        switch (routine)
        {
            case "ribbon":
                difficulty = 9.100;
                performanmce = 9.400;
                break;
            case "hoop":
                difficulty = 9.300;
                performanmce = 9.800;
                break;
            case "rope":
                difficulty = 9.600;
                performanmce = 9.000;
                break;
        }
        break;
    case "Bulgaria":
        switch (routine)
        {
            case "ribbon":
                difficulty = 9.600;
                performanmce = 9.400;
                break;
            case "hoop":
                difficulty = 9.550;
                performanmce = 9.750;
                break;
            case "rope":
                difficulty = 9.500;
                performanmce = 9.400;
                break;
        }
        break;
    case "Italy":
        switch (routine)
        {
            case "ribbon":
                difficulty = 9.200;
                performanmce = 9.500;
                break;
            case "hoop":
                difficulty = 9.450;
                performanmce = 9.350;
                break;
            case "rope":
                difficulty = 9.700;
                performanmce = 9.150;
                break;
        }
        break;
}

double score = difficulty + performanmce;
double percentToFull = ((20.000 - (double)score) / 20) * 100;

Console.WriteLine($"The team of {country} get {score:F3} on {routine}.");
Console.WriteLine($"{percentToFull:F2}%");
