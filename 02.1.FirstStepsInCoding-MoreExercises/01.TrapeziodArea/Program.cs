﻿/* 1.	Лице на трапец
Напишете програма, която чете от конзолата три дробни числа b1, b2 и h и пресмята лицето на трапец с основи b1 и b2 и височина h. 
Формулата за лице на трапец е (b1 + b2) * h / 2.
На фигурата по-долу е показан трапец със страни 8 и 13 и височина 7. Той има лице (8 + 13) * 7 / 2 = 73.5.
Отговорът трябва да е форматиран до втората цифра след десетичния знак.
*/

// Input

double b1Side = double.Parse(Console.ReadLine());
double b2Side = double.Parse(Console.ReadLine());
double hSide = double.Parse(Console.ReadLine());

// Calculations

double area = ((b1Side + b2Side) * hSide) / 2;
string formattedArea= area.ToString("0.00");

// Output

Console.WriteLine(formattedArea);