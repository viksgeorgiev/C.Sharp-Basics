int age = int.Parse(Console.ReadLine());
double washingMachine = double.Parse(Console.ReadLine());  
int toyPrice  = int.Parse(Console.ReadLine());

int evenBirthdays = 0;
int oddBirthays = 0;

for (int i = 1; i <= age; i++)
{
    if (i % 2 == 0 )
    {
        evenBirthdays += i * 5 - 1;
    }
    else
    {
        oddBirthays += toyPrice;
    }
}

int sum = evenBirthdays + oddBirthays;

if (sum >= washingMachine )
{
    Console.WriteLine($"Yes! {(sum - washingMachine):F2}");
}
else
{
    Console.WriteLine($"No! {(washingMachine - sum):F2}");
}