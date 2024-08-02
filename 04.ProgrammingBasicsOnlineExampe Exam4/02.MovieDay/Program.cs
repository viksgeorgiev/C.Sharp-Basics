
int timeForShoot = int.Parse(Console.ReadLine());
int scenes  = int.Parse(Console.ReadLine());
int sceneTime  = int.Parse(Console.ReadLine());

double time = timeForShoot - timeForShoot * 0.15;

double shootTime = scenes * sceneTime;

if (time > shootTime)
{
    Console.WriteLine($"You managed to finish the movie on time! You have {Math.Round(time - shootTime)} minutes left!");
}
else
{
    Console.WriteLine($"Time is up! To complete the movie you need {Math.Round(shootTime - time)} minutes.");
}