int badGrades = int.Parse(Console.ReadLine());
int badGradesCounter = 0;
int goodGradesCounter = 0;
int goodGradesSum = 0;
string problemName = String.Empty;
string lastBookName = String.Empty;

while (true)
{
    problemName = Console.ReadLine();
    if (problemName == "Enough")
    {
        Console.WriteLine($"Average score: {(double)goodGradesSum / (goodGradesCounter + badGradesCounter):F2}");
        Console.WriteLine($"Number of problems: {goodGradesCounter + badGradesCounter}");
        Console.WriteLine($"Last problem: {lastBookName}");
        break;
    }
    
    lastBookName = problemName;  
    int grade = int.Parse(Console.ReadLine());

    if (grade <= 4)
    {
        badGradesCounter++;
        goodGradesSum += grade;
    }
    else
    {
        goodGradesCounter++;
        goodGradesSum += grade;
    }
    if (badGrades == badGradesCounter)
    {
        Console.WriteLine($"You need a break, {badGradesCounter} poor grades.");
        break;
    }
}