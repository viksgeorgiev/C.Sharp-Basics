double inheritance = double.Parse(Console.ReadLine());
int year  = int.Parse(Console.ReadLine());

for (int i = 1800; i <= year; i++)
{
    if (i % 2 == 0)
    {
        inheritance -= 12000;
    }
    else
    {
        inheritance -= 12000 + ((i - 1800 + 18 ) * 50);
    }
}

if (inheritance >= 0)
{
    Console.WriteLine($"Yes! He will live a carefree life and will have {inheritance:F2} dollars left.");
}
else
{
    Console.WriteLine($"He will need {Math.Abs(inheritance):F2} dollars to survive.");
}