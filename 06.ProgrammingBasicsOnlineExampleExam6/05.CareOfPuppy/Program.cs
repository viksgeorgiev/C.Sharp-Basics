
int dogFood = int.Parse(Console.ReadLine()) * 1000;

string input = Console.ReadLine();    
int allFoodEaten = 0;


while(input != "Adopted")
{
    int foodEaten = int.Parse(input);

    allFoodEaten += foodEaten;


    input = Console.ReadLine();
}


if(allFoodEaten <= dogFood)
{
    Console.WriteLine($"Food is enough! Leftovers: {dogFood - allFoodEaten} grams.");
}
else
{
    Console.WriteLine($"Food is not enough. You need {allFoodEaten - dogFood} grams more.");
}