
int numberOfCats = int.Parse(Console.ReadLine());

int counterSmallCats = 0;
int counterMediumCats = 0;
int counterLargeCats = 0;

double allFood = 0;

double costForFood = 0; 

for (int i = 1; i <= numberOfCats; i++)
{
    double gramsOfFood = double.Parse(Console.ReadLine());
    if (gramsOfFood >= 100 && gramsOfFood < 200)
    {
        counterSmallCats++;
    }
    else if (gramsOfFood >= 200 && gramsOfFood < 300)
    {
        counterMediumCats++;
    }
    else if (gramsOfFood >= 300)
    {
        counterLargeCats++;
    }
    allFood += gramsOfFood;
}

double allFoodInKilos = allFood / 1000;

double allFoodPrice = allFoodInKilos * 12.45;

Console.WriteLine($"Group 1: {counterSmallCats} cats.");
Console.WriteLine($"Group 2: {counterMediumCats} cats.");
Console.WriteLine($"Group 3: {counterLargeCats} cats.");
Console.WriteLine($"Price for food per day: {allFoodPrice:F2} lv.");