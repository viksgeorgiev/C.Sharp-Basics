/* Напишете програма, която чете градуси по скалата на Целзий (°C) и ги преобразува до градуси по скалата на Фаренхайт (°F). 
 * Потърсете в Интернет подходяща формула, с която да извършите изчисленията.
 * Форматирате изхода до втория знак след десетичната запетая. 
 *  F = (9/5) * C + 32
 */

// Input

double celsius = double.Parse(Console.ReadLine());

// Calculations

double farenheit = ((9 * celsius) / 5 + 32);

// Output

string formattedFarenheit = farenheit.ToString("0.00");

Console.WriteLine(formattedFarenheit);