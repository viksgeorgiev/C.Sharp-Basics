
int minutesPerDay = int.Parse(Console.ReadLine());
int walksPerDay  = int.Parse(Console.ReadLine());
int caloriesIntake  = int.Parse(Console.ReadLine());

int walkedMinutes = minutesPerDay * walksPerDay;

int calories = walkedMinutes * 5;
double halfOfCalories = caloriesIntake * 0.50;

if(calories >= halfOfCalories)
{
    Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {calories}.");
}
else
{
    Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {calories}.");
}