﻿// vhod moneti ot tip double
double coins = double.Parse(Console.ReadLine()) * 100;

int coinCounter = 0;
// while cikyl
// s if proverki za vsi4ki moneti

while (coins > 0)
{
    if (coins >= 200)
    {
        coins -= 200; 
    }
    else if (coins >= 100)
    {
        coins -= 100;
    }
    else if (coins >= 50)
    {
        coins -= 50;
    }
    else if (coins >= 20)
    {
        coins -= 20;
    }
    else if (coins >= 10)
    {
        coins -= 10;
    }
    else if (coins >= 5)
    {
        coins -= 5;
    }
    else if (coins >= 2)
    {
        coins -= 2;
    }
    else if (coins >= 1)
    {
        coins -= 1;
    }
    else
    {
        break;
    }

    coinCounter++;
}
Console.WriteLine(coinCounter);