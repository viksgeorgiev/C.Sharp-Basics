//конзолата се четат 2 реда:
//На първия ред са броят на гостите – цяло число в интервала [0 ... 200000]
//На втория ред е бюджетът с който разполага Любо  – цяло число в интервала [0 ... 200000]
//

int guests = int.Parse(Console.ReadLine());
int budget = int.Parse(Console.ReadLine());

int eggs = guests * 2;
double kozunacs =  Math.Ceiling((double)guests / 3);

double cost = (eggs * 0.45) + (kozunacs * 4);


if (cost > budget)
{
    Console.WriteLine($"Lyubo doesn't have enough money.");
    Console.WriteLine($"He needs {cost - budget:F2} lv. more.");
}
else
{
    Console.WriteLine($"Lyubo bought {kozunacs} Easter bread and {eggs} eggs.");
    Console.WriteLine($"He has {budget - cost:F2} lv. left.");
}