double number = double.Parse(Console.ReadLine());

while (number >= 0)
{
    Console.WriteLine($"Result: {(number*2):F2}");
    number = double.Parse(Console.ReadLine());
}
Console.WriteLine("Negative number!");