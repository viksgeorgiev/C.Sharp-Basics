int juniorCyclists = int.Parse(Console.ReadLine());
int seniorCyclists = int.Parse(Console.ReadLine());
string courseType = Console.ReadLine();

double juniorsContribution = 0;
double seniorContribution = 0;

switch (courseType)
{
    case "trail":
        juniorsContribution = juniorCyclists * 5.50;
        seniorContribution = seniorCyclists * 7;
        break;
    case "cross-country":
        if ((seniorCyclists + juniorCyclists) >= 50)
        {
            juniorsContribution = juniorCyclists * (8 * 0.75);
            seniorContribution = seniorCyclists * (9.50 * 0.75);
        }
        else
        {
            juniorsContribution = juniorCyclists * 8;
            seniorContribution = seniorCyclists * 9.50;
        }
        break;
    case "downhill":
        juniorsContribution = juniorCyclists * 12.25;
        seniorContribution = seniorCyclists * 13.75;
        break;
    case "road":
        juniorsContribution = juniorCyclists * 20;
        seniorContribution = seniorCyclists * 21.50;
        break;
}
double sum = juniorsContribution + seniorContribution;
sum -= sum * 0.05;

Console.WriteLine($"{sum:F2}");
