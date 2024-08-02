int pairs = int.Parse(Console.ReadLine());
int difference = 0;
int previousSum = 0;

for (int i = 1; i <= pairs; i++)
{
    if(i == 1)
    {
        int firstNum = int.Parse(Console.ReadLine());
        int secondNum = int.Parse(Console.ReadLine());
        previousSum = firstNum + secondNum;
    }
    else
    {
        int firstnum = int.Parse(Console.ReadLine());
        int secondNum = int.Parse(Console.ReadLine());
        int currentSum = firstnum + secondNum;

        if(Math.Abs(currentSum - previousSum) > Math.Abs(difference))
        {
            difference = Math.Abs(currentSum - previousSum);
            previousSum = currentSum;
        }
    }
}

if (difference > 0)
{
    Console.WriteLine($"No, maxdiff={difference}");
}
else
{
    Console.WriteLine($"Yes, value={previousSum}");
}