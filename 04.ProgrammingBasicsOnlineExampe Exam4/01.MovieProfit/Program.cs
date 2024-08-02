

string movieName = Console.ReadLine();
int daysNumber = int.Parse(Console.ReadLine());
int ticketsNumber = int.Parse(Console.ReadLine());
double ticketPrice  = double.Parse(Console.ReadLine());
int percentForCinema  = int.Parse(Console.ReadLine());

double ticketsCost = ticketsNumber * ticketPrice;
double allDays = ticketsCost * daysNumber;
double cinemaProfit = allDays * percentForCinema / 100;
double finalProfit = allDays - cinemaProfit;

Console.WriteLine($"The profit from the movie {movieName} is {finalProfit:F2} lv.");