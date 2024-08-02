
string movieName = Console.ReadLine();
string moviePacket  = Console.ReadLine();
int ticketCount = int.Parse(Console.ReadLine());

double total = 0;

switch (movieName)
{
	case "John Wick":
        switch (moviePacket)
        {
            case "Drink":
                total = ticketCount * 12; 
                break;
            case "Popcorn":
                total = ticketCount * 15;
                break;
            case "Menu":
                total = ticketCount * 19;
                break;
        }
        break;
    case "Star Wars":
        switch (moviePacket)
        {
            case "Drink":
                total = ticketCount * 18;
                break;
            case "Popcorn":
                total = ticketCount * 25;
                break;
            case "Menu":
                total = ticketCount * 30;
                break;
        }
        break;
    case "Jumanji":
        switch (moviePacket)
        {
            case "Drink":
                total = ticketCount * 9;
                break;
            case "Popcorn":
                total = ticketCount * 11;
                break;
            case "Menu":
                total = ticketCount * 14;
                break;
        }
        break;
}

if (movieName == "Star Wars" && ticketCount >= 4 )
{
    total -= total * 0.30;
}
if (movieName == "Jumanji" && ticketCount == 2)
{
    total -= total * 0.15;
}

Console.WriteLine($"Your bill is {total:F2} leva.");
