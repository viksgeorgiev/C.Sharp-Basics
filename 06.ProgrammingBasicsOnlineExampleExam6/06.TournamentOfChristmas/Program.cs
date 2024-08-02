
int daysOfTournament = int.Parse(Console.ReadLine());
double moneyForCharity = 0;
int daysWonCounter = 0;
int daysLostCounter = 0;

bool isWon = false;

for (int i = 1; i <= daysOfTournament; i++)
{
    string sport = Console.ReadLine();
    int counterWon = 0;
    int counterLost = 0;
    double moneyForTheDay = 0;
    while (sport != "Finish")
    {
        string result = Console.ReadLine();

        if (result == "win")
        {
            moneyForTheDay += 20;
            counterWon++;
        }
        else
        {
            counterLost++;
        }

        sport = Console.ReadLine();
    }

    if (counterWon > counterLost)
    {
        moneyForTheDay += moneyForTheDay * 0.10;
        daysWonCounter++;
    }
    else
    {
        daysLostCounter++;
    }

    moneyForCharity += moneyForTheDay;
}
if (daysWonCounter > daysLostCounter)
{
    isWon = true;
    moneyForCharity += moneyForCharity * 0.20;
}

if (isWon)
{
    Console.WriteLine($"You won the tournament! Total raised money: {moneyForCharity:F2}");
}
else
{
    Console.WriteLine($"You lost the tournament! Total raised money: {moneyForCharity:F2}");
}