//
//Първи ред – брой дни – цяло число в интервал [1…5000]
//Втори ред – оставена храна в килограми – цяло число в интервал [0…100000]
//Трети ред – храна на ден за кучето в килограми – реално число в интервал [0.00…100.00]
//Четвърти ред – храна на ден за котката в килограми– реално число в интервал [0.00…100.00]
//Пети ред – храна на ден за костенурката в грамове – реално число в интервал [0.00…10000.00]

int days = int.Parse(Console.ReadLine());
int foodLeft = int.Parse(Console.ReadLine());
double dog = double.Parse(Console.ReadLine());
double cat = double.Parse(Console.ReadLine());
double tortoise = double.Parse(Console.ReadLine()) / 1000;

double foodEaten = (dog + cat + tortoise) * days;

if (foodEaten <= foodLeft)
{
    Console.WriteLine($"{Math.Floor(foodLeft - foodEaten)} kilos of food left.");
}
else
{
    Console.WriteLine($"{Math.Ceiling(foodEaten - foodLeft)} more kilos of food are needed.");
}