int number = int.Parse(Console.ReadLine());

int digit = 1;

for (int i = 1; i <= number; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write($"{digit} ");
        digit++;
        if (digit > number)
        {
            break;
        }
    }
    if (digit > number)
    {
        break;
    }
    Console.WriteLine();
}