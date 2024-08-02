int x1 = int.Parse(Console.ReadLine());
int x2  = int.Parse(Console.ReadLine());
int magicNumber = int.Parse(Console.ReadLine());

int combinations = 0;
bool isEnd = false;

for (int i = x1; i <= x2 ; i++)
{
    for (int j = x1; j <= x2 ; j++)
    {
        combinations++;
        if(i + j == magicNumber)
        {
            Console.WriteLine($"Combination N:{combinations} ({i} + {j} = {magicNumber})");
            isEnd = true;
            break;
        }
    }

    if (isEnd) { break;}
}

if(!isEnd)
{
    Console.WriteLine($"{combinations} combinations - neither equals {magicNumber}");
}