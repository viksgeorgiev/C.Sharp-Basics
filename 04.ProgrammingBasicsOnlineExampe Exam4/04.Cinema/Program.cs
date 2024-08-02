
int capacity = int.Parse(Console.ReadLine());
string input = Console.ReadLine();

bool isFull = false;
int income = 0;

while (input != "Movie time!")
{
    int peopleEntering = int.Parse(input);

    if (peopleEntering > capacity)
    {
        isFull = true;
        break;
    }

    if (peopleEntering % 3 == 0)
    {
        income += peopleEntering * 5 - 5;
        capacity -= peopleEntering;
    }
    else
    {
        income += peopleEntering * 5;
        capacity -= peopleEntering;
    }

    input = Console.ReadLine();
}

if (isFull == false)
{
    Console.WriteLine($"There are {capacity} seats left in the cinema.");
}
else
{
    Console.WriteLine("The cinema is full.");
}

Console.WriteLine($"Cinema income - {income} lv.");