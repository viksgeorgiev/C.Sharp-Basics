int stadium = int.Parse(Console.ReadLine());
int allFans = int.Parse(Console.ReadLine());

int sectorA = 0;
int sectorB = 0;
int sectorV = 0;
int sectorG = 0;

for (int i = 1; i <= allFans; i++)
{
	string input = Console.ReadLine();
	switch (input)
	{
		case "A":
            sectorA++;
			break;
        case "B":
            sectorB++;
            break;
        case "V":
            sectorV++;
            break;
        case "G":
            sectorG++;
            break;
    }
}

double percentA = (double)sectorA / allFans * 100;
double percentB = (double)sectorB / allFans * 100;
double percentV = (double)sectorV / allFans * 100;
double percentG = (double)sectorG / allFans * 100;
double percentStadium = ((sectorA + sectorB + sectorV + sectorG) / (double)stadium) * 100;

Console.WriteLine($"{percentA:F2}%");
Console.WriteLine($"{percentB:F2}%");
Console.WriteLine($"{percentV:F2}%");
Console.WriteLine($"{percentG:F2}%");
Console.WriteLine($"{percentStadium:F2}%");