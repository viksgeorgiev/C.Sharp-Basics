string playerOne = Console.ReadLine();
string playerTwo = Console.ReadLine();

string cardOne  = Console.ReadLine();
string cardTwo = Console.ReadLine();

int pointsGamerOne = 0;
int pointsGamerTwo = 0;

bool numberWars = false;

while (cardOne != "End of game")
{
    int inPlayOne = int.Parse(cardOne);
    int inPlayTwo = int.Parse(cardTwo);

    if (inPlayOne > inPlayTwo)
    {
        pointsGamerOne += inPlayOne - inPlayTwo;
    }
    else if (inPlayOne < inPlayTwo)
    {
        pointsGamerTwo += inPlayTwo - inPlayOne;
    }
    else if (inPlayOne == inPlayTwo)
    {
        numberWars = true;
        
        inPlayOne = int.Parse(Console.ReadLine());
        inPlayTwo = int.Parse(Console.ReadLine());

        if (inPlayOne > inPlayTwo)
        {
            int difference = inPlayOne - inPlayTwo;
            Console.WriteLine("Number wars!");
            Console.WriteLine($"{playerOne} is winner with {pointsGamerOne} points");
        }
        else if (inPlayOne < inPlayTwo)
        {
            int difference = inPlayTwo - inPlayOne;
            Console.WriteLine("Number wars!");
            Console.WriteLine($"{playerTwo} is winner with {pointsGamerTwo} points");
        }
        
    }
    if (numberWars) { break; }
    cardOne  = Console.ReadLine();
    if (cardOne == "End of game")
    { continue; }
    cardTwo = Console.ReadLine();
}

if (numberWars == false)
{
    Console.WriteLine($"{playerOne} has {pointsGamerOne} points");
    Console.WriteLine($"{playerTwo} has {pointsGamerTwo} points");
}