
string input = Console.ReadLine();

int maxPoints = int.MinValue;
string strongestWord = string.Empty;

while (input != "End of words")
{
    int currentPoints = 0;

    for (int i = 0; i < input.Length; i++)
    {
        currentPoints += input[i];
    }

    if (input[0] == 'A' || input[0] == 'E' || input[0] == 'O' || input[0] == 'U' || input[0] == 'Y' || input[0] == 'I' || input[0] == 'a' || input[0] == 'e' || input[0] == 'o' || input[0] == 'u' || input[0] == 'y' || input[0] == 'i')
    {
        currentPoints *= input.Length;
    }
    else
    {
        currentPoints = (int)Math.Floor((double)currentPoints / input.Length);
    }

    if (currentPoints > maxPoints)
    {
        maxPoints = currentPoints;
        strongestWord = input;
    }


    input = Console.ReadLine();
}

Console.WriteLine($"The most powerful word is {strongestWord} - {maxPoints}");