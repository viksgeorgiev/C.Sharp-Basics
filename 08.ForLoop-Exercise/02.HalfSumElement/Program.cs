int n = int.Parse(Console.ReadLine());

int sum = 0;
int maxNumber = int.MinValue;

for (int i = 1; i <= n; i++)
{
    int input = int.Parse(Console.ReadLine());
    sum += input;
    if (input > maxNumber)
    {
        maxNumber = input;
    }
}

sum -= maxNumber;

if (sum == maxNumber)
{
    Console.WriteLine("Yes");
    Console.WriteLine($"Sum = {sum}");
}
else
{
    Console.WriteLine("No");
    Console.WriteLine($"Diff = {Math.Abs(sum -maxNumber)}");
}