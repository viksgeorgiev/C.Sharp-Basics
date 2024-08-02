string playerName = Console.ReadLine();

int maxNumber = int.MinValue;
string bestPlayer = string.Empty;

while (playerName != "Stop")
{
    int currentNumber = 0;

    for (int i = 0; i < playerName.Length; i++)
    {
        int inputNumber = int.Parse(Console.ReadLine());
        
        if (inputNumber == playerName[i])
        {
            currentNumber += 10;
        }
        else 
        {
            currentNumber += 2;
        }
    }

    if (currentNumber >= maxNumber)
    {
        maxNumber = currentNumber;
        bestPlayer = playerName;
    }

    playerName = Console.ReadLine();
}

Console.WriteLine($"The winner is {bestPlayer} with {maxNumber} points!");