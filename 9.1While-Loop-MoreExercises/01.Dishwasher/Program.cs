int detergent = int.Parse(Console.ReadLine()) * 750;

string input = Console.ReadLine();
int counter = 1;
int counterPots = 0;
int counterDishes = 0;



while (input != "End")
{
    if (detergent >= 0)
    {
        if (counter % 3 == 0)
        {
            int tableware = int.Parse(input);
            detergent -= (15 * tableware);
            counterPots += tableware;
            if (detergent < 0) { continue; }
        }
        else
        {
            int tableware = int.Parse(input);
            detergent -= (5 * tableware);
            counterDishes += tableware;
            if (detergent < 0) {continue;}
        }
    }
    else
    {
        Console.WriteLine($"Not enough detergent, {Math.Abs(detergent)} ml. more necessary!");
        break;
    }
    counter++;   
    input = Console.ReadLine(); 
}
if (input == "End")
{
    Console.WriteLine("Detergent was enough!");
    Console.WriteLine($"{counterDishes} dishes and {counterPots} pots were washed.");
    Console.WriteLine($"Leftover detergent {detergent} ml.");
}


