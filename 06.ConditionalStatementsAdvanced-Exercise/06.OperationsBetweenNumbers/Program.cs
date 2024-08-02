// Input

double num1 = double.Parse(Console.ReadLine());
double num2 = double.Parse(Console.ReadLine());
string operation = Console.ReadLine();
double answer = 0;

if (operation == "+")
{
	answer = num1 + num2;
	if (answer % 2 == 0)
	{
		Console.WriteLine($"{num1} + {num2} = {answer} - even");
	}
	else
	{
        Console.WriteLine($"{num1} + {num2} = {answer} - odd");
    }
}
else if (operation == "-")
{
    answer = num1 - num2;
    if (answer % 2 == 0)
    {
        Console.WriteLine($"{num1} - {num2} = {answer} - even");
    }
    else
    {
        Console.WriteLine($"{num1} - {num2} = {answer} - odd");
    }
}
else if (operation == "*")
{
    answer = num1 * num2;
    if (answer % 2 == 0)
    {
        Console.WriteLine($"{num1} * {num2} = {answer} - even");
    }
    else
    {
        Console.WriteLine($"{num1} * {num2} = {answer} - odd");
    }
}
else if (operation == "/")
{
    if (num2 != 0)
    {
        answer = num1 / num2;
        Console.WriteLine($"{num1} / {num2} = {answer:F2}");
    }
    else
    {
        Console.WriteLine($"Cannot divide {num1} by zero");
    }
}
else if (operation == "%")
{
    if (num2 != 0)
    {
        answer = num1 % num2;
        Console.WriteLine($"{num1} % {num2} = {answer}");
    }
    else
    {
        Console.WriteLine($"Cannot divide {num1} by zero");
    }
}

