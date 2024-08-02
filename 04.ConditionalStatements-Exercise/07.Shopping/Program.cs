// Input

double peterBudget = double.Parse(Console.ReadLine());
int videoCards = int.Parse(Console.ReadLine());
int cpus  = int.Parse(Console.ReadLine());
int rams = int.Parse(Console.ReadLine());

double videoCardsCost = videoCards * 250;
double cpuCost = cpus*(videoCardsCost * 0.35);
double ramCost = rams*(videoCardsCost * 0.10);

double cost = videoCardsCost + cpuCost + ramCost;

if  (videoCards > cpus)
{
    cost -= cost * 0.15;
}

if  (cost <= peterBudget)
{
    Console.WriteLine($"You have {(peterBudget - cost):f2} leva left!");
}
else
{
    Console.WriteLine($"Not enough money! You need {(cost - peterBudget):f2} leva more!");
}