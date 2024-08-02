//Когато пуснали билетите за Евро 2016, група запалянковци решили да си закупят. Билетите имат две категории с различни цени:
//  VIP – 499.99 лева.
//  Normal – 249.99 лева.
//Запалянковците имат определен бюджет, а броят на хората в групата определя какъв
//процент от бюджета трябва да се задели за транспо
//  От 1 до 4 – 75% от бюджета.
//  От 5 до 9 – 60% от бюджета.
//  От 10 до 24 – 50% от бюджета.
//  От 25 до 49 – 40% от бюджета.
//  50 или повече – 25% от бюджета.


//Входът се чете от конзолата и съдържа точно 3 реда:
//	На първия ред е бюджетът – реално число в интервала [1 000.00 ... 1 000 000.00]
//	На втория ред е категорията – "VIP" или "Normal"
//	На третия ред е броят на хората в групата – цяло число в интервала [1 ... 200]

double budget = double.Parse(Console.ReadLine());
string category = Console.ReadLine();
int fans = int.Parse(Console.ReadLine());
double tickets = 0;
double transport = 0;
double vipTicket = 499.99;
double normalTicket = 249.99;

switch (category)
{
	case "VIP": 
        if (fans <= 4)
        {
            transport = budget * 0.75;
            tickets = fans * vipTicket;
        }
        else if(fans <= 9)
        {
            transport = budget * 0.60;
            tickets = fans * vipTicket;
        }
        else if (fans <= 24)
        {
            transport = budget * 0.50;
            tickets = fans * vipTicket;
        }
        else if (fans <= 49)
        {
            transport = budget * 0.40;
            tickets = fans * vipTicket;
        }
        else if (fans >= 50)
        {
            transport = budget * 0.25;
            tickets = fans * vipTicket;
        }
        break;

    case "Normal":
        if (fans <= 4)
        {
            transport = budget * 0.75;
            tickets = fans * normalTicket;
        }
        else if (fans <= 9)
        {
            transport = budget * 0.60;
            tickets = fans * normalTicket;
        }
        else if (fans <= 24)
        {
            transport = budget * 0.50;
            tickets = fans * normalTicket;
        }
        else if (fans <= 49)
        {
            transport = budget * 0.40;
            tickets = fans * normalTicket;
        }
        else if (fans >= 50)
        {
            transport = budget * 0.25;
            tickets = fans * normalTicket;
        }

        break;
}

if ((budget - (transport + tickets)) >= 0 )
{
    Console.WriteLine($"Yes! You have {(budget - (transport + tickets)):F2} leva left.");
}
else
{
    Console.WriteLine($"Not enough money! You need {((transport + tickets) - budget):F2} leva.");
}