/* Напишете програма, която да пресмята колко литра боя е нужна за боядисването на къщa. Като за стените се използва зелена боя, 
 * а за покрива – червена. Разхода на зелената боя е 1 литър за 3.4 м2, а на червената – 1 литър за 4.3 м2.
Стените имат следните размери:
•	Предната и задната стена са квадрати със страна „x“
o	на предната стена има правоъгълна врата с широчина 1.2м и височина 2м
•	Страничните стени са правоъгълници със страни „x“ и „y“
o	и на двете странични стени има по един квадратен прозорец със страна 1.5м
Покривът има следните размери:
•	Два правоъгълника със страни „x“ и „y“
•	Два равностранни триъгълника със страна „x“ и височина „h“
Трябва да пресметнете площта на всички страни и площта на покрива, за да
намерите колко литра от всяка боя ще са нужни.
Вход
От конзолата се четат 3 реда:
1.	x – височината на къщата – реално число в интервала [2...100]
2.	y – дължината на страничната стена – реално число в интервала [2...100]
3.	h – височината на триъгълната стена на прокрива – реално число в интервала [2...100]
Изход
Да се отпечатат на конзолата две числа всяко на нов ред:
•	Литрите зелена боя
•	Литритe червена боя
Форматирани до вторият знак след десетичната запетая.
*/

// Input

double xHeightHouse = double.Parse(Console.ReadLine());
double yLength = double.Parse(Console.ReadLine());
double hHeightTriangle = double.Parse(Console.ReadLine());

// Calculations

double frontAndBackWall = ((xHeightHouse * xHeightHouse) * 2) - (1.2 * 2);
double sideWalls = ((xHeightHouse * yLength) * 2) - ((1.5 * 1.5) * 2);
double ceilingSquare = 2 * (xHeightHouse * yLength);
double ceilingtriangles = 2 * ((xHeightHouse * hHeightTriangle) / 2);

double paintGreen = (frontAndBackWall + sideWalls) / 3.4;
double paintRed = (ceilingSquare + ceilingtriangles) / 4.3;


string formattedPaintGreen = paintGreen.ToString("0.00");
string formattedPaintRed = paintRed.ToString("0.00");

// Output

Console.WriteLine(formattedPaintGreen);
Console.WriteLine(formattedPaintRed);