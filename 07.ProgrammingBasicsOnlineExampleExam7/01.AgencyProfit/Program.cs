
string airline = Console.ReadLine();
int adultTickets = int.Parse(Console.ReadLine());
int kidsTickets  = int.Parse(Console.ReadLine());
double netPriceAdultTicket  = double.Parse(Console.ReadLine());
double taxFeeTicket = double.Parse(Console.ReadLine());

double netPriceKidsTicket = netPriceAdultTicket * 0.30;

double priceAdultTicket = netPriceAdultTicket + taxFeeTicket;
double priceKidsTicket = netPriceKidsTicket + taxFeeTicket;

double costAdultTickets = adultTickets * priceAdultTicket;
double costKidsTicket = kidsTickets * priceKidsTicket;

double allTicketsCost = costAdultTickets + costKidsTicket;
double agencyProfit = allTicketsCost * 0.20;

Console.WriteLine($"The profit of your agency from {airline} tickets is {agencyProfit:F2} lv.");