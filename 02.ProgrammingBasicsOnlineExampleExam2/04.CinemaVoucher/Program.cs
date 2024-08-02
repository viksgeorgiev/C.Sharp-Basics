int voucher = int.Parse(Console.ReadLine());

string input = Console.ReadLine();

int counterMovies = 0;
int counterFood = 0;
bool isBreak = false;

while (input != "End")
{
    if (voucher == 0)
    { break; }

    if (input.Length > 8)
    {
        int price = input[0] + input[1];
        if (price <= voucher) 
        {
            counterMovies++;
            voucher -= price;
        }
        else
        {
            isBreak = true;
            break;
        }
    }
    else
    {
        int price = input[0];
        if (price <= voucher)
        {
            counterFood++;
            voucher -= price;
        }
        else
        {
            isBreak = true;
            break;
        }
    }
    if (isBreak == true) { break; }
    input = Console.ReadLine();
}

Console.WriteLine($"{counterMovies}");
Console.WriteLine($"{counterFood}");