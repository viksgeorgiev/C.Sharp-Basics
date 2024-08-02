/* Напишете програма, която чете от конзолата страна и височина на триъгълник и пресмята неговото лице. 
 * Използвайте формулата за лице на триъгълник: area = a * h / 2. 
 * Форматирате изхода до втория знак след десетичната запетая.
 * */

// Input

double aSide = double.Parse(Console.ReadLine());
double hOfTriangle = double.Parse(Console.ReadLine());

// Calculations

double area = aSide * (hOfTriangle / 2);

string areaFormatted = area.ToString("0.00");

// Output

Console.WriteLine(areaFormatted);