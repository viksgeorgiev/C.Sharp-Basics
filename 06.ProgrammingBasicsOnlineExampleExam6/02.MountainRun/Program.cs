
double secondsRecord = double.Parse(Console.ReadLine());
double distanceMeters = double.Parse(Console.ReadLine());
double metersInSecond = double.Parse(Console.ReadLine());

double heightClimbedTime = distanceMeters * metersInSecond;

double timesSlowed = Math.Floor((distanceMeters / 50));

heightClimbedTime += timesSlowed * 30;

if (heightClimbedTime < secondsRecord)
{
    Console.WriteLine($" Yes! The new record is {heightClimbedTime:F2} seconds.");
}
else
{
    Console.WriteLine($"No! He was {heightClimbedTime - secondsRecord:F2} seconds slower.");
}

