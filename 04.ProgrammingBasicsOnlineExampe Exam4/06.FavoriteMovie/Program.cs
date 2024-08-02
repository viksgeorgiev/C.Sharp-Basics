string input = Console.ReadLine();

int currentBest = int.MinValue;
string currentNameOfBest = string.Empty;
int movieCounter = 0;
bool isReached = false;

while (input != "STOP")
{
    if (movieCounter == 7) 
    {
        isReached = true;
        break; 
    }
    
    int lengthOfCycle = input.Length;
    int pointsForMovie = 0;

    for (int i = 0; i < lengthOfCycle; i++)
    {
        pointsForMovie += input[i];

        if (input[i] > 96 && input[i] < 123)
        {
            pointsForMovie -= input.Length * 2;
        }
        else if (input[i] > 64 && input[i] < 91)
        {
            pointsForMovie -= input.Length;
        }
    }
    
    if (pointsForMovie > currentBest)
    {
        currentBest = pointsForMovie;
        currentNameOfBest = input;
    }

    movieCounter++;
    input = Console.ReadLine();
}

if (isReached == true)
{
    Console.WriteLine("The limit is reached.");
}
Console.WriteLine($"The best movie for you is {currentNameOfBest} with {currentBest} ASCII sum.");