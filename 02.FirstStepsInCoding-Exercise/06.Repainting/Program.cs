/* 
•	Предпазен найлон - 1.50 лв. за кв. метър
•	Боя - 14.50 лв. за литър
•	Разредител за боя - 5.00 лв. за литър
За всеки случай, към необходимите материали, Румен иска да добави още 10% от количеството боя и 2 кв.м. найлон, разбира се и 0.40 лв. за торбички. 
Сумата, която се заплаща на майсторите за 1 час работа, е равна на 30% от сбора на всички разходи за материали.

Входът се чете от конзолата и съдържа точно 4 реда:
1.	Необходимо количество найлон (в кв.м.) - цяло число в интервала [1... 100]
2.	Необходимо количество боя (в литри) - цяло число в интервала [1…100]
3.	Количество разредител (в литри) - цяло число в интервала [1…30]
4.	Часовете, за които майсторите ще свършат работата - цяло число в интервала [1…9]
Изход
Да се отпечата на конзолата един ред:
•	"{сумата на всички разходи}"
*/

// Input

double footageNylon = (double.Parse(Console.ReadLine()) + 2) * 1.50;
double paintInput = double.Parse(Console.ReadLine());
double paintNeeded = (paintInput + (paintInput * 0.1)) * 14.50;
double paintDiluent = double.Parse(Console.ReadLine()) * 5;
double paintersWorksHours = double.Parse(Console.ReadLine());

//Calculations

double sumMaterials = footageNylon + paintNeeded + paintDiluent + 0.40;
double paintersFee = (sumMaterials * 0.3) * paintersWorksHours;

//Output

Console.WriteLine(sumMaterials + paintersFee);