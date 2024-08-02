
string drink = Console.ReadLine();
string sugar = Console.ReadLine();
int drinksNumber = int.Parse(Console.ReadLine());

double cost = 0;

switch (drink)
{
    case "Espresso":
        switch (sugar)
        {
            case "Without":
                cost = drinksNumber * 0.90;
                cost -= cost * 0.35;
                break;
            case "Normal":
                cost = drinksNumber * 1;
                break;
            case "Extra":
                cost = drinksNumber * 1.20;
                break;
        }
        break;
    case "Cappuccino":
        switch (sugar)
        {
            case "Without":
                cost = drinksNumber * 1;
                cost -= cost * 0.35;
                break;
            case "Normal":
                cost = drinksNumber * 1.20;
                break;
            case "Extra":
                cost = drinksNumber * 1.60;
                break;
        }
        break;
    case "Tea":
        switch (sugar)
        {
            case "Without":
                cost = drinksNumber * 0.50;
                cost -= cost * 0.35;
                break;
            case "Normal":
                cost = drinksNumber * 0.60;
                break;
            case "Extra":
                cost = drinksNumber * 0.70;
                break;
        }
        break;
}
if (drink == "Espresso" && drinksNumber >= 5)
{
    cost -= cost * 0.25;    
}
if (cost > 15)
{
    cost -= cost * 0.20;
}

Console.WriteLine($"You bought {drinksNumber} cups of {drink} for {cost:F2} lv.");