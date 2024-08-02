int juree = int.Parse(Console.ReadLine());
string presentation = Console.ReadLine();

int counterGrades = 0;
double allGrades = 0;

while (presentation != "Finish")
{
    double grades = 0;
    
    for (int i = 1; i <= juree; i++)
    {
        double input = double.Parse(Console.ReadLine());
        grades += input;
        counterGrades++;
        allGrades += input;
    }

    double avgGrade = grades / juree;
    Console.WriteLine($"{presentation} - {avgGrade:F2}.");

    presentation = Console.ReadLine();
}

double allGradesAverage = allGrades / counterGrades;
Console.WriteLine($"Student's final assessment is {allGradesAverage:F2}.");