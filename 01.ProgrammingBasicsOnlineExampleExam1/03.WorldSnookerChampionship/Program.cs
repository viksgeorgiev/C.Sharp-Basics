string stage = Console.ReadLine();
string ticketType = Console.ReadLine();
int ticketsAmount = int.Parse(Console.ReadLine());
string trophyPicture  = Console.ReadLine();

double ticketPrice = 0;
bool freePicture = false;

switch (stage)
{
    case "Quarter final":
        switch (ticketType)
        {
            case "Standard":
                ticketPrice = 55.50;
                break;
            case "Premium":
                ticketPrice = 105.20;
                break;
            case "VIP":
                ticketPrice = 118.90;
                break;
        }
        break;
    case "Semi final":
        switch (ticketType)
        {
            case "Standard":
                ticketPrice = 75.88;
                break;
            case "Premium":
                ticketPrice = 125.22;
                break;
            case "VIP":
                ticketPrice = 300.40;
                break;
        }
        break;
    case "Final":
        switch (ticketType)
        {
            case "Standard":
                ticketPrice = 110.10;
                break;
            case "Premium":
                ticketPrice = 160.66;
                break;
            case "VIP":
                ticketPrice = 400;
                break;
        }
        break;
}

double price = ticketPrice * ticketsAmount;


if (price > 4000)
{
    price -= price * 0.25;
    freePicture = true;
}
else if ( price > 2500)
{
    price -= price * 0.10;
}

if (trophyPicture == "Y" && freePicture == false)
{
    price += ticketsAmount * 40;
}

Console.WriteLine($"{price:F2}");