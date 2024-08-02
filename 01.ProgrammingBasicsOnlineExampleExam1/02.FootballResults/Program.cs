string firstGame = Console.ReadLine();
string secondGame = Console.ReadLine();
string thirdGame = Console.ReadLine();

int counterWon = 0;
int counterLost = 0;
int counterDraw = 0;

if (firstGame[0] > firstGame[2])
{
    counterWon++;
}
else if (firstGame[0] < firstGame[2])
{
    counterLost++;
}
else if (firstGame[0] == firstGame[2])
{
    counterDraw++;
}

if (secondGame[0] > secondGame[2])
{
    counterWon++;
}
else if (secondGame[0] < secondGame[2])
{
    counterLost++;
}
else if (secondGame[0] == secondGame[2])
{
    counterDraw++;
}

if (thirdGame[0] > thirdGame[2])
{
    counterWon++;
}
else if (thirdGame[0] < thirdGame[2])
{
    counterLost++;
}
else if (thirdGame[0] == thirdGame[2])
{
    counterDraw++;
}

Console.WriteLine($"Team won {counterWon} games.");
Console.WriteLine($"Team lost {counterLost} games.");
Console.WriteLine($"Drawn games: {counterDraw}");