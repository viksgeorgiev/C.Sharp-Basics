// "Back", "Chest", "Legs", "Abs", "Protein shake" или "Protein bar"


int members = int.Parse(Console.ReadLine());

string activity = string.Empty;

int counterWorkOut = 0;
int counterProtein = 0;

int counterBack = 0;
int counterChest = 0;
int counterLegs = 0;
int counterAbs = 0;
int counterShake = 0;
int counterBar = 0;

for (int i = 1; i <= members; i++)
{
	activity = Console.ReadLine();
	switch (activity)
	{
		case "Back":
            counterWorkOut++;
            counterBack++;
            break;
        case "Chest":
            counterWorkOut++;
            counterChest++;
            break;
        case "Legs":
            counterWorkOut++;
            counterLegs++;
            break;
        case "Abs":
            counterWorkOut++;
            counterAbs++;
            break;
        case "Protein shake":
            counterShake++;
            counterProtein++;
            break;
        case "Protein bar":
            counterProtein++;
            counterBar++;
            break;
    }
}

double percentTraining = (double)counterWorkOut / members * 100;
double percentProtein = (double)counterProtein / members * 100;

Console.WriteLine($"{counterBack} - back");
Console.WriteLine($"{counterChest} - chest");
Console.WriteLine($"{counterLegs} - legs");
Console.WriteLine($"{counterAbs} - abs");
Console.WriteLine($"{counterShake} - protein shake");
Console.WriteLine($"{counterBar} - protein bar");
Console.WriteLine($"{percentTraining:F2}% - work out");
Console.WriteLine($"{percentProtein:F2}% - protein");
