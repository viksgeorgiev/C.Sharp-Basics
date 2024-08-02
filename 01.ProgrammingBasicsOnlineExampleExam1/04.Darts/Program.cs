string playerName = Console.ReadLine();

string zone = string.Empty;
int points = 0;

int leg = 301;
int counter = 0;
int badshots = 0;


while(zone != "Retire")
{
    if(leg == 0)
    { break; }

	zone = Console.ReadLine();
    if (zone == "Retire")
    {
        continue;
    }

    points = int.Parse(Console.ReadLine());
    int inPlay = 0;

	switch (zone)
	{
		case "Single":
            inPlay = points;
            if (inPlay <= leg)
            {
                counter++;
                leg -= inPlay;
            }
            else
            {
                badshots++;
            }
			break;
        case "Double":
            inPlay = points * 2;
            if (inPlay <= leg)
            {
                counter++;
                leg -= inPlay;
            }
            else
            {
                badshots++;
            }
            break;
        case "Triple":
            inPlay = points * 3;
            if (inPlay <= leg)
            {
                counter++;
                leg -= inPlay;
            }
            else
            {
                badshots++;
            }
            break;
    }
}

if (leg == 0)
{
    Console.WriteLine($"{playerName} won the leg with {counter} shots.");
}
else
{
    Console.WriteLine($"{playerName} retired after {badshots} unsuccessful shots.");
}