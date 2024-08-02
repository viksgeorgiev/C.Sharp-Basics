string n = Console.ReadLine();
int lastSymbolOfN = n.Length - 1;
int isFive = int.Parse(n[lastSymbolOfN].ToString());

bool isFound = false;


for (int a = 1; a <=9; a++)
{
    for (int b = 9; b >= a; b--)
    {
        for (int c = 0; c <= 9; c++)
        {
            for(int d = 9;  d >= c; d--) 
            {
                if (a + b + c + d == a * b * c * d)
                {
                    if (isFive == 5)
                    {
                        Console.WriteLine($"{a}{b}{c}{d}");
                        isFound = true;
                        break;
                    }
                }
                else if ((a * b * c * d) / (a + b + c + d) == 3) 
                {
                    if(int.Parse(n) % 3 == 0)
                    {
                        Console.WriteLine($"{d}{c}{b}{a}");
                        isFound = true;
                        break;
                    }    
                }
                
            }
            if (isFound == true)
            {
                break;
            }
        }
        if (isFound == true)
        {
            break;
        }
    }
    if (isFound == true)
    {
        break;
    }
}

if (isFound == false)
{
    Console.WriteLine("Nothing found");
}