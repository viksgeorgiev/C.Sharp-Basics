string name = Console.ReadLine();
int classCount = 0;
int failedClass = 2;
double sumOfGrades = 0;


while (classCount < 12)
{
    double gradeInput = double.Parse(Console.ReadLine());
    if (gradeInput >= 4)
    {
 
        sumOfGrades += gradeInput;
    }
    else
    {     
        failedClass--;
    }

    if(failedClass == 0)
    {
        Console.WriteLine($"{name} has been excluded at {classCount} grade");
        break;
    }
    classCount++;
}

if(classCount == 12)
{
    Console.WriteLine($"{name} graduated. Average grade: {(sumOfGrades / 12):F2}");
}