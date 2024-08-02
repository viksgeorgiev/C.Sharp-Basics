// Prices

double puzzlePrice = 2.60;
double dollPrice = 3;
double bearPrice = 4.10;
double minionPrice = 8.20;
double truckPrice = 2;


// Input

double holidayPrice = double.Parse(Console.ReadLine());
int puzzleQuantity = int.Parse(Console.ReadLine());
int dollQuantity = int.Parse(Console.ReadLine());
int bearQuantity = int.Parse(Console.ReadLine());
int minionQuantity = int.Parse(Console.ReadLine());
int truckQuantity = int.Parse(Console.ReadLine());

int toysQuantity = puzzleQuantity + dollQuantity + bearQuantity + minionQuantity + truckQuantity;
double toysPrice = (puzzleQuantity * puzzlePrice) + (dollPrice * dollQuantity) + (bearPrice * bearQuantity) + (minionQuantity * minionPrice) + (truckQuantity * truckPrice);

if (toysQuantity >= 50)
{
    toysPrice -= (toysPrice * 0.25);
}

toysPrice -= (toysPrice * 0.10);

if (toysPrice >= holidayPrice)

{
    double money = toysPrice - holidayPrice;
    Console.WriteLine($"Yes! {money:f2} lv left.");
}
else
{
    double money = holidayPrice - toysPrice;
    Console.WriteLine($"Not enough money! {money:f2} lv needed.");
}