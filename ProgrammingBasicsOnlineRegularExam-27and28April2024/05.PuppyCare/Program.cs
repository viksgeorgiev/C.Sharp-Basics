
int gramsFood = int.Parse(Console.ReadLine()) * 1000;

string input = Console.ReadLine();

while(input != "Adopted")
{
    int gramsEaten = int.Parse(input);
    
    
    gramsFood -= gramsEaten;

    input = Console.ReadLine();
}

if(gramsFood >= 0)
{
    Console.WriteLine($"Food is enough! Leftovers: {gramsFood} grams.");
}
else 
{
    Console.WriteLine($"Food is not enough. You need {Math.Abs(gramsFood)} grams more.");
}

