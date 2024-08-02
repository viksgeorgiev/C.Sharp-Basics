using System.Diagnostics.SymbolStore;

string input = Console.ReadLine();

int sumPrime = 0;
int sumNonPrime = 0;

while (input != "stop")
{
    int number = int.Parse(input);
    input = Console.ReadLine();
    bool isPrime = true;

    if (number < 0)
    {
        Console.WriteLine("Number is negative.");
        continue;
    }
    for (int i = 2; i <= number / 2; i++)
    {
        if (number % i == 0)
        {
            sumNonPrime += number;
            isPrime = false;
            break;
        }
    }
    if (isPrime) 
    {
        sumPrime += number;
    }
    
}

Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
Console.WriteLine($"Sum of all non prime numbers is: {sumNonPrime}");