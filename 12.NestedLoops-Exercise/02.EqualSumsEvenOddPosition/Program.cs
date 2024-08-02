int number1 = int.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());

for (int i = number1;  i <= number2; i++)
{
    int oddSum = 0;
    int evenSum = 0;

    string currentNum = i.ToString();

    for (int j = 0; j < currentNum.Length; j++)
    {
        if (j % 2 == 0) 
        {
            evenSum += currentNum[j];
        }
        else if (j % 2 == 1)
        {
             oddSum += currentNum[j];
        }
    }
    if (oddSum == evenSum) 
    {
        Console.Write($"{currentNum} ");
    }
}