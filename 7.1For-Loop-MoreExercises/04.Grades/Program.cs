int attended = int.Parse(Console.ReadLine());

double grades = 0;
int highGrade = 0;
int goodGrade = 0;
int normalGrade = 0;
int badGrade = 0;

for (int i = 1; i <= attended; i++)
{
    double input = double.Parse(Console.ReadLine());
    grades += input;
    if (input < 3 )
    {
        badGrade++;
    }
    else if (input <= 3.99) 
    {
        normalGrade++;
    }
    else if (input <= 4.99)
    {
        goodGrade++;
    }
    else
    {
        highGrade++;
    }
}


Console.WriteLine($"Top students: {(double)highGrade / attended * 100:F2}%");
Console.WriteLine($"Between 4.00 and 4.99: {(double)goodGrade / attended * 100:F2}%");
Console.WriteLine($"Between 3.00 and 3.99: {(double)normalGrade / attended * 100:F2}%");
Console.WriteLine($"Fail: {(double)badGrade / attended * 100:F2}%");
Console.WriteLine($"Average: {(double)grades / attended:F2}");