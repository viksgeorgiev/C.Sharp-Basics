int targetNumber = int.Parse(Console.ReadLine());
int sum = 0;

while (true)
{
    int inputNumber = int.Parse(Console.ReadLine());
    sum += inputNumber;
    if (sum >= targetNumber)
    {
        Console.WriteLine(sum);
        break;
    }
}

