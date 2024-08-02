
double budgetForActors = double.Parse(Console.ReadLine());

string input = Console.ReadLine();

bool isOver = false;

while (input != "ACTION")
{
	if (input.Length <= 15)
	{
		double actorInputedBudget = double.Parse(Console.ReadLine());
		budgetForActors -= actorInputedBudget;
		if (budgetForActors < 0) {
			isOver = true;
			break; }
	}
	else 
	{
		budgetForActors = budgetForActors * 0.80;
    }

	if(budgetForActors < 0)
	{
		isOver = true;
		break;
	}

    input = Console.ReadLine();
}

if (isOver == false)
{
    Console.WriteLine($"We are left with {budgetForActors:F2} leva.");
}
else
{
    Console.WriteLine($"We need {Math.Abs(budgetForActors):F2} leva for our actors.");
}