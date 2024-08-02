int mintutesControl = int.Parse(Console.ReadLine()) * 60;
int secondsControl = int.Parse(Console.ReadLine());
double metersLong  = double.Parse(Console.ReadLine());
int secondsPerMeter  = int.Parse(Console.ReadLine());

int timeToBeat = mintutesControl + secondsControl;

double timeCutMeters = metersLong / 120;

double timeCuted = timeCutMeters * 2.5;

double marinTime = (metersLong / 100) * secondsPerMeter - timeCuted;

if (timeToBeat >= marinTime)
{
    Console.WriteLine($"Marin Bangiev won an Olympic quota!");
    Console.WriteLine($"His time is {marinTime:F3}.");
}
else
{
    Console.WriteLine($"No, Marin failed! He was {marinTime - timeToBeat:F3} second slower.");
}