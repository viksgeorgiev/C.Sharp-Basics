// Input

using System.Diagnostics.Metrics;

int hourOfExam = int.Parse(Console.ReadLine());
int minutesOfExam  = int.Parse(Console.ReadLine());
int hourArrival  = int.Parse(Console.ReadLine());
int minutesArrival  = int.Parse(Console.ReadLine());

int timeOfExam = (hourOfExam * 60) + minutesOfExam;
int timeOfArrival = (hourArrival * 60) + minutesArrival;

if (timeOfArrival > timeOfExam )
{
    Console.WriteLine("Late");

    if ((timeOfArrival - timeOfExam) <= 59)
    {
        Console.WriteLine($"{(timeOfArrival - timeOfExam)} minutes after the start");
    }
    else
    {
        int timeToPrint = (timeOfArrival - timeOfExam) / 60;
        int minutesToPrint = (timeOfArrival - timeOfExam) % 60;
        Console.WriteLine($"{timeToPrint}:{minutesToPrint:D2} hours after the start");
    }
}
else if ((timeOfArrival <= timeOfExam) && ((timeOfExam - timeOfArrival) <= 30))
{
    Console.WriteLine("On Time");
    if (timeOfExam - timeOfArrival >= 0  && timeOfExam - timeOfArrival < 1)
    {

    }
    else
    {
        Console.WriteLine($"{timeOfExam - timeOfArrival} minutes before the start");
    }
}
else
{
    Console.WriteLine("Early");
    if ((timeOfExam - timeOfArrival) <= 59)
    {
        Console.WriteLine($"{(timeOfExam - timeOfArrival)} minutes before the start");
    }
    else
    {
        int timeToPrint = (timeOfExam - timeOfArrival) / 60;
        int minutesToPrint = (timeOfExam - timeOfArrival) % 60;
        Console.WriteLine($"{timeToPrint}:{minutesToPrint:D2} hours before the start");
    }
}
















