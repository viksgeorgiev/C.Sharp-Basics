int months = int.Parse(Console.ReadLine());

double electricity = 0;
double water = 0;
double internet = 0;
double others = 0;


for (int i = 1; i <= months; i++)
{
    double input = double.Parse(Console.ReadLine());
    electricity += input;
    others += (input + 20 + 15) + (input + 20 + 15) * 0.20;
}


Console.WriteLine($"Electricity: {electricity:F2} lv");
Console.WriteLine($"Water: {months * 20:F2} lv");
Console.WriteLine($"Internet: {months * 15:F2} lv");
Console.WriteLine($"Other: {others:F2} lv");
Console.WriteLine($"Average: {(electricity + (months * 20) + (months * 15) + others) / months:F2} lv");