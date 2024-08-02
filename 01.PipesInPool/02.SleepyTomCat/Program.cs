//Том е 30 000  минути в година. Времето за игра на Том зависи от почивните дни на стопанина му:
//•	Когато е на работа, стопанинът му си играе с него по 63 минути на ден.
//•	Когато почива, стопанинът му си играе с него  по 127 минути на ден.
//Напишете програма, която въвежда броя почивни дни и отпечатва дали Том може да се наспи добре и колко е разликата от нормата за
//текущата година, като приемем че годината има 365 дни.


int daysOff = int.Parse(Console.ReadLine());

int tomPlay = (365 - daysOff) * 63 + daysOff * 127;

int norm = 30000 - tomPlay;
int hours = Math.Abs(norm) / 60;
int minutes = Math.Abs(norm) % 60;

if (norm >= 0)
{
    Console.WriteLine("Tom sleeps well");
    Console.WriteLine($"{hours} hours and {minutes} minutes less for play");
}
else
{
    Console.WriteLine("Tom will run away");
    Console.WriteLine($"{hours} hours and {minutes} minutes more for play");
}