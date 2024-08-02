string movieTitle = Console.ReadLine();

int counterStudent = 0;
int counterStandart = 0;
int counterkids = 0;
int allTickets = 0;

while (movieTitle != "Finish")
{
    int availableSeats = int.Parse(Console.ReadLine());
    string seatType = Console.ReadLine();
    int counterTickets = 0;

    while (seatType != "End")
    {
        if (seatType == "standard")
        {
            counterStandart++;
            counterTickets++;
            allTickets++;
        }
        else if (seatType == "student")
        {
            counterStudent++;
            counterTickets++;
            allTickets++;
        }
        else if (seatType == "kid")
        {  
            counterkids++; 
            counterTickets++;
            allTickets++;
        }

        if (counterTickets == availableSeats)
        {
            double percentOccupancyLocal = (double)counterTickets / availableSeats * 100;
            Console.WriteLine($"{movieTitle} - {percentOccupancyLocal:F2}% full.");
            break;
        }
        seatType = Console.ReadLine();
    }
    if (seatType == "Finish") { break; }
    if (counterTickets != availableSeats)
    {
        double percentOccupancy = (double)counterTickets / availableSeats * 100;
        Console.WriteLine($"{movieTitle} - {percentOccupancy:F2}% full.");
    }


    movieTitle = Console.ReadLine();
}

double studentTicketsPercent = (double)counterStudent / allTickets * 100;
double standartTicketsPercent = (double)counterStandart / allTickets * 100;
double kidsTicketsPercent = (double)counterkids / allTickets * 100;

Console.WriteLine($"Total tickets: {allTickets}");
Console.WriteLine($"{studentTicketsPercent:F2}% student tickets.");
Console.WriteLine($"{standartTicketsPercent:F2}% standard tickets.");
Console.WriteLine($"{kidsTicketsPercent:F2}% kids tickets.");