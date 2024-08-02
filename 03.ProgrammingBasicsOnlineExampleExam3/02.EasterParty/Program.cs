

int guests = int.Parse(Console.ReadLine());
double invitePerPerson = double.Parse(Console.ReadLine());
double budget =  double.Parse(Console.ReadLine());

if (guests >= 10 && guests <= 15)
{
    invitePerPerson -= invitePerPerson * 0.15; 
}
else if (guests <= 20 && guests > 15)
{
    invitePerPerson -= invitePerPerson * 0.20;
}
else if (guests > 20)
{
    invitePerPerson -= invitePerPerson * 0.25;
}

double cakePrice = budget * 0.10;

double moneyNeeded = guests * invitePerPerson + cakePrice;

if (moneyNeeded > budget)
{
    Console.WriteLine($"No party! {moneyNeeded - budget:F2} leva needed.");
}
else
{
    Console.WriteLine($"It is party time! {budget - moneyNeeded:F2} leva left.");
}