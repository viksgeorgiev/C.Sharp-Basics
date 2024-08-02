
int a1 = int.Parse(Console.ReadLine());
int a2 = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());

int forFirst = a2 - 1;
int forSecond = n - 1;
int forThird = (n / 2) - 1;

for (int symbol1 = a1; symbol1 <= forFirst; symbol1++)
{
    for (int symbol2 = 1; symbol2 <= forSecond; symbol2++)
    {
        for (int symbol3 = 1; symbol3 <= forThird; symbol3++)
        {

            int symbol4 = (char)symbol1;


            if (symbol1 % 2 == 1 && (symbol2 + symbol3 + symbol4) % 2 == 1)
            {
                Console.WriteLine($"{(char)symbol1}-{symbol2}{symbol3}{symbol4}");
            }
        }
    }
}