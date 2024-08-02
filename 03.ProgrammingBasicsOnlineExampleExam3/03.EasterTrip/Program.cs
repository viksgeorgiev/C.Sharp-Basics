//Дестинация      21-23 март	24-27 март	28-31 март
//Франция           30 лв.	    35 лв.	    40 лв.
//Италия	        28 лв.	    32 лв.	    39 лв.
//Германия	        32 лв.	    37 лв.	    43 лв.


string destination = Console.ReadLine();
string dates  = Console.ReadLine();
int nights = int.Parse(Console.ReadLine());

int cost = 0;

switch (destination)
{
	case "France":
        switch (dates)
        {
            case "21-23":
                cost = nights * 30;
                break;
            case "24-27":
                cost = nights * 35;
                break;
            case "28-31":
                cost = nights * 40;
                break;
        }
        break;
    case "Italy":
        switch (dates)
        {
            case "21-23":
                cost = nights * 28;
                break;
            case "24-27":
                cost = nights * 32;
                break;
            case "28-31":
                cost = nights * 39;
                break;
        }
        break;
    case "Germany":
        switch (dates)
        {
            case "21-23":
                cost = nights * 32;
                break;
            case "24-27":
                cost = nights * 37;
                break;
            case "28-31":
                cost = nights * 43;
                break;
        }
        break;
}



Console.WriteLine($"Easter trip to {destination} : {cost:F2} leva.");