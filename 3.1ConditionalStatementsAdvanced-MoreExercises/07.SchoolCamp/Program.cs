//	Сезонът – текст - “Winter”, “Spring” или “Summer”;
//	Видът на групата – текст - “boys”, “girls” или “mixed”;
//	Брой на учениците – цяло число в интервала [1 … 10000];
//	Брой на нощувките – цяло число в интервала [1 … 100].
//


string season = Console.ReadLine();
string groupType  = Console.ReadLine();
int students = int.Parse(Console.ReadLine());
int nights  = int.Parse(Console.ReadLine());

double price = 0;
string sport = String.Empty;

switch (season)
{
	case "Spring":
        switch (groupType)
        {
            case "boys":
            case "girls":
                price += students * nights * 7.20;
                if (groupType == "boys")
                {
                    sport = "Tennis";
                }
                else if (groupType == "girls")
                {
                    sport = "Athletics";
                }
            break;
            case "mixed":
                price += students * nights * 9.50;
                sport = "Cycling";
            break;
        }
        break;
    case "Summer":
        switch (groupType)
        {
            case "boys":
            case "girls":
                price += students * nights * 15;
                if (groupType == "boys")
                {
                    sport = "Football";
                }
                else if (groupType == "girls")
                {
                    sport = "Volleyball";
                }
                break;
            case "mixed":
                price += students * nights * 20;
                sport = "Swimming";
                break;
        }
        break;
    case "Winter":
        switch (groupType)
        {
            case "boys":
            case "girls":
                price += students * nights * 9.60;
                if (groupType == "boys")
                {
                    sport = "Judo";
                }
                else if (groupType == "girls")
                {
                    sport = "Gymnastics";
                }
                break;
            case "mixed":
                price += students * nights * 10;
                sport = "Ski";
                break;
        }
        break;
}

if (students >= 10 && students < 20 )
{
    price -= price * 0.05;
}
else if (students >= 20 && students < 50)
{
    price -= price * 0.15;
}
else if (students >= 50)
{
    price -= price * 0.5;
}

Console.WriteLine($"{sport} {price:F2} lv.");