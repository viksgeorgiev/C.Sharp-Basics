//      Филм                normal	    luxury	    ultra luxury
//A Star Is Born	        7.50 лв.	10.50 лв.	13.50 лв.
//Bohemian Rhapsody	        7.35 лв.	9.45 лв.	12.75 лв.
//Green Book	            8.15 лв.	10.25 лв.	13.25 лв.
//The Favourite	            8.75 лв.	11.55 лв.	13.95 лв.

string movie = Console.ReadLine();
string teather  = Console.ReadLine();
int tickets = int.Parse(Console.ReadLine());

double income = 0;

switch (movie)
{
	case "A Star Is Born":
        switch (teather)
        {
            case "normal":
                income = tickets * 7.50;
                break;
            case "luxury":
                income = tickets * 10.50;
                break;
            case "ultra luxury":
                income = tickets * 13.50;
                break;
        }
        break;
    case "Bohemian Rhapsody":
        switch (teather)
        {
            case "normal":
                income = tickets * 7.35;
                break;
            case "luxury":
                income = tickets * 9.45;
                break;
            case "ultra luxury":
                income = tickets * 12.75;
                break;
        }
        break;
    case "Green Book":
        switch (teather)
        {
            case "normal":
                income = tickets * 8.15;
                break;
            case "luxury":
                income = tickets * 10.25;
                break;
            case "ultra luxury":
                income = tickets * 13.25;
                break;
        }
        break;
    case "The Favourite":
        switch (teather)
        {
            case "normal":
                income = tickets * 8.75;
                break;
            case "luxury":
                income = tickets * 11.55;
                break;
            case "ultra luxury":
                income = tickets * 13.95;
                break;
        }
        break;
}


Console.WriteLine($"{movie} -> {income:F2} lv.");