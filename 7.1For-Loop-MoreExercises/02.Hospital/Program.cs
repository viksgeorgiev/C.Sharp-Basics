int days = int.Parse(Console.ReadLine());

int doctors = 7;
int examined = 0;
int sentAway = 0;

for (int i = 1; i <= days; i++)
{
    if (i % 3 == 0 && sentAway > examined)
    {
        doctors++;
    }
    int patients = int.Parse(Console.ReadLine());
    if (patients >= doctors)
    {
        examined += doctors;
        sentAway += patients - doctors;
    }
    else
    {
        examined += patients;
        
    }
    
}

Console.WriteLine($"Treated patients: {examined}.");
Console.WriteLine($"Untreated patients: {sentAway}.");