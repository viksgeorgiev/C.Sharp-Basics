// Input

double record = double.Parse(Console.ReadLine());
double distance  = double.Parse(Console.ReadLine());   
double meterPerSecond = double.Parse(Console.ReadLine());

double delay = Math.Floor(distance / 15) * 12.5;

double secondsRecord = (distance * meterPerSecond) + delay;

if (record > secondsRecord)
{
    Console.WriteLine($" Yes, he succeeded! The new world record is {secondsRecord:f2} seconds.");
}
else
{
    Console.WriteLine($"No, he failed! He was {(secondsRecord - record):f2} seconds slower.");
}