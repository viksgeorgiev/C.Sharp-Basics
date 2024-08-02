string userNmawe = Console.ReadLine();
string passWord  = Console.ReadLine();
string input = Console.ReadLine();

while (input != passWord)
{
    input = Console.ReadLine();
}
Console.WriteLine($"Welcome {userNmawe}!");