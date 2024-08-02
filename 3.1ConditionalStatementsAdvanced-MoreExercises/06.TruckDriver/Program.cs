using System.ComponentModel.Design;

string season = Console.ReadLine();
double monthKilometers = double.Parse(Console.ReadLine());

double salary = 0;

switch (season)
{
	case "Spring":
	case "Autumn":
		if (monthKilometers <= 5000)
		{
            salary = 4 * monthKilometers * 0.75;
		}
		else if (monthKilometers <= 10000)
		{
            salary = 4 * monthKilometers * 0.95;
        }
		else
		{
            salary = 4 * monthKilometers * 1.45;
        }	
        break;

	case "Summer":
        if (monthKilometers <= 5000)
        {
            salary = 4 * monthKilometers * 0.90;
        }
        else if (monthKilometers <= 10000)
        {
            salary = 4 * monthKilometers * 1.10;
        }
        else
        {
            salary = 4 * monthKilometers * 1.45;
        }
        break;

	case "Winter":
        if (monthKilometers <= 5000)
        {
            salary = 4 * monthKilometers * 1.05;
        }
        else if (monthKilometers <= 10000)
        {
            salary = 4 * monthKilometers * 1.25;
        }
        else
        {
            salary = 4 * monthKilometers * 1.45;
        }
        break;
}

salary -= salary * 0.10;

Console.WriteLine($"{salary:F2}");