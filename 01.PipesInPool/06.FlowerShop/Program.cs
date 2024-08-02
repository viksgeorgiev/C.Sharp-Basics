//
//	Брой магнолии – цяло число в интервала [0 … 50]
//	Брой зюмбюли – цяло число в интервала [0 … 50]
//	Брой рози – цяло число в интервала [0 … 50]
//	Брой кактуси – цяло число в интервала [0 … 50]
//	Цена на подаръка – реално число в интервала [0.00 … 500.00]
//

double magnolias = int.Parse(Console.ReadLine()) * 3.25;
double plums = int.Parse(Console.ReadLine()) * 4;
double roses = int.Parse(Console.ReadLine()) * 3.50;
double cacti = int.Parse(Console.ReadLine()) * 8;
double giftPrice = double.Parse(Console.ReadLine());

double profit = magnolias + plums + roses + cacti;
profit -= profit * 0.05; 

if (profit >= giftPrice)
{
    Console.WriteLine($"She is left with {Math.Floor(profit - giftPrice)} leva.");
}
else
{
    Console.WriteLine($"She will have to borrow {Math.Ceiling(giftPrice - profit)} leva.");
}