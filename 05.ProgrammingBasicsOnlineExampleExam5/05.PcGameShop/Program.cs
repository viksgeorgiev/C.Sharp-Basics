
int gamesSold = int.Parse(Console.ReadLine());
string gameName = string.Empty;

int counterAll = 0;
int counterHearthstone = 0;
int counterFornite = 0;
int counterOverwatch = 0;
int counterOthers = 0;

for (int i = 1; i <= gamesSold; i++)
{
	gameName = Console.ReadLine();
	switch (gameName)
	{
		case "Hearthstone":
			counterAll++;
            counterHearthstone++;
			break;
        case "Fornite":
            counterAll++;
            counterFornite++;
            break;
        case "Overwatch":
            counterAll++;
            counterOverwatch++;
            break;
        default:
            counterAll++;
            counterOthers++;
            break;
	}
}

double percentHearthstone = (double)counterHearthstone / counterAll * 100;
double percentFornite = (double)counterFornite / counterAll * 100;
double percentOverwatch = (double)counterOverwatch / counterAll * 100;
double percentOthers = (double)counterOthers / counterAll * 100;

Console.WriteLine($"Hearthstone - {percentHearthstone:F2}%");
Console.WriteLine($"Fornite - {percentFornite:F2}%");
Console.WriteLine($"Overwatch - {percentOverwatch:F2}%");
Console.WriteLine($"Others - {percentOthers:F2}%");
