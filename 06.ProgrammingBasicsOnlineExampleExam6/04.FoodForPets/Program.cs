
int days = int.Parse(Console.ReadLine());
double foodAll = double.Parse(Console.ReadLine());

int foodEatenByDog = 0;
int foodEatenByCat = 0;
double biscuits = 0;


for (int i = 1; i <= days; i++)
{
    int foodDog = int.Parse(Console.ReadLine());
    int foodCat = int.Parse(Console.ReadLine());

    foodEatenByCat += foodCat;
    foodEatenByDog += foodDog;



    if (i % 3 == 0)
    {
        biscuits += (foodDog + foodCat) * 0.10;
    }
}

double foodBoth = foodEatenByCat + foodEatenByDog;

double percentEatenAll = (foodEatenByCat + foodEatenByDog) / foodAll * 100;
double percentEatenDog = (foodEatenByDog) / foodBoth * 100;
double percentEatenCat = (foodEatenByCat) / foodBoth * 100;

Console.WriteLine($"Total eaten biscuits: {Math.Round(biscuits)}gr.");
Console.WriteLine($"{percentEatenAll:F2}% of the food has been eaten.");
Console.WriteLine($"{percentEatenDog:F2}% eaten from the dog.");
Console.WriteLine($"{percentEatenCat:F2}% eaten from the cat.");