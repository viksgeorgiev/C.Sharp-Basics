/* 
•	Пилешко меню –  10.35 лв. 
•	Меню с риба – 12.40 лв. 
•	Вегетарианско меню  – 8.15 лв. 
Напишете програма, която изчислява колко ще струва на група хора да си поръчат храна за вкъщи.
Групата ще си поръча и десерт, чиято цена е равна на 20% от общата сметка (без доставката). 
Цената на доставка е 2.50 лв и се начислява най-накрая.  
Вход
От конзолата се четат 3 реда:
•	Брой пилешки менюта – цяло число в интервала [0 … 99]
•	Брой менюта с риба – цяло число в интервала [0 … 99]
•	Брой вегетариански менюта – цяло число в интервала [0 … 99]
*/
//Input

double chickenMenu = double.Parse(Console.ReadLine()) * 10.35;
double fishMenu = double.Parse(Console.ReadLine()) * 12.40;
double vegiMenu = double.Parse(Console.ReadLine()) * 8.15;

//Calculations

double sum = chickenMenu + fishMenu + vegiMenu;
double desert = sum * 0.2;

//Output

Console.WriteLine(sum + desert + 2.50);