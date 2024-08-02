int numbers = int.Parse(Console.ReadLine());

int counter = 1;
double sum = 0;

while (counter <= numbers )
{
    sum += int.Parse(Console.ReadLine());
    counter++;
}

Console.WriteLine($"{sum / numbers:F2}");