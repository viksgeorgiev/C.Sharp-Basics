string movie = Console.ReadLine();

int totalTickets = 0;

int standartTickets = 0;
int studentTickets = 0;
int kidTickets = 0;

while (movie != "Finish")
{
    int seats = int.Parse(Console.ReadLine());
    string ticket = Console.ReadLine();
    int ticketCounter = 0;

    while (ticket != "End")
    {
        totalTickets++;
        ticketCounter++;
        switch (ticket)
        {
            case "student":
                studentTickets++;
                break;
            case "standard":
                standartTickets++; 
                break;
            case "kid":
                kidTickets++;
                break;
        }
        if (ticketCounter == seats)
        {
            break;
        }
        ticket = Console.ReadLine();
    }

    Console.WriteLine($"{movie} - {(double)ticketCounter / seats * 100:F2}% full.");

    movie = Console.ReadLine();
}

Console.WriteLine($"Total tickets: {totalTickets}");
Console.WriteLine($"{(double)studentTickets / totalTickets * 100:F2}% student tickets.");
Console.WriteLine($"{(double)standartTickets / totalTickets * 100:F2}% standard tickets.");
Console.WriteLine($"{(double)kidTickets / totalTickets * 100:F2}% kids tickets.");