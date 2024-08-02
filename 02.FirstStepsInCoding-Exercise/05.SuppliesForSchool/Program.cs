//•	Пакет химикали - 5.80 лв. 
//•	Пакет маркери - 7.20 лв. 
//•	Препарат - 1.20 лв (за литър)

//•	Брой пакети химикали - цяло число в интервала [0...100]
//•	Брой пакети маркери - цяло число в интервала [0...100]
//•	Литри препарат за почистване на дъска - цяло число в интервала [0…50]
//•	Процент намаление - цяло число в интервала [0...100]

//Input 

double pens = double.Parse(Console.ReadLine()) * 5.80;
double markers = double.Parse(Console.ReadLine()) * 7.20;
double detergent = double.Parse(Console.ReadLine()) * 1.20;
double percentage = double.Parse(Console.ReadLine()) / 100;

// Calculations
double sum = (pens + markers + detergent);

double discount = (sum) * percentage;

double finalPrice = sum - discount;

Console.WriteLine(finalPrice);

