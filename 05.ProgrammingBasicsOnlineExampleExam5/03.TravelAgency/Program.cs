
string cityName = Console.ReadLine();
string packetType = Console.ReadLine();
string isVIP = Console.ReadLine();
int daysVisit = int.Parse(Console.ReadLine());

double cost = 0;
bool isInvalid = false;
 
if (daysVisit > 7)
{
    daysVisit = daysVisit - 1;
}

switch (cityName)
{
	case "Bansko":
	case "Borovets":
        switch (packetType)
        {
            case "noEquipment":
                if (isVIP == "yes")
                {
                    cost = daysVisit * 80;
                    cost -= cost * 0.05; 
                }
                else
                {
                    cost = daysVisit * 80;
                }
                break;
            case "withEquipment":
                if (isVIP == "yes")
                {
                    cost = daysVisit * 100;
                    cost -= cost * 0.10;
                }
                else
                {
                    cost = daysVisit * 100;
                }
                break;
            default: Console.WriteLine("Invalid input!");
                isInvalid = true;
                break;
        }
        break;
        
    case "Varna":
    case "Burgas":
        switch (packetType)
        {
            case "noBreakfast":
                if (isVIP == "yes")
                {
                    cost = daysVisit * 100;
                    cost -= cost * 0.07;
                }
                else
                {
                    cost = daysVisit * 100;
                }
                break;
            case "withBreakfast":
                if (isVIP == "yes")
                {
                    cost = daysVisit * 130;
                    cost -= cost * 0.12;
                }
                else
                {
                    cost = daysVisit * 130;
                }
                break;
            default: Console.WriteLine("Invalid input!");
                isInvalid = true;
                break;
        }
        break;
    default:
        Console.WriteLine("Invalid input!");
        isInvalid = true;
        break;
}

if (isInvalid == false && daysVisit >= 1)
{
    Console.WriteLine($"The price is {cost:F2}lv! Have a nice time!");
}
else if (isInvalid == false && daysVisit < 1)
{
    Console.WriteLine("Days must be positive number!");
}