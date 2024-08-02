
//              Червено(Red)   Зелено(Green)  Жълто(Yellow)
//Големи(Large)     16 лв.           12 лв.         9 лв.
//Средни(Medium)    13 лв.           9 лв.          7 лв.
//Малки(Small)      9 лв.            8 лв.          5 лв.



string eggSize = Console.ReadLine();
string eggColor = Console.ReadLine();
int eggAmount  = int.Parse(Console.ReadLine());

double total = 0;

switch (eggSize)
{
	case "Large":
        switch (eggColor)
        {
            case "Red":
                total = eggAmount * 16;
                break;
            case "Green":
                total = eggAmount * 12;
                break;
            case "Yellow":
                total = eggAmount * 9;
                break;
        }
        break;
    case "Medium":
        switch (eggColor)
        {
            case "Red":
                total = eggAmount * 13;
                break;
            case "Green":
                total = eggAmount * 9;
                break;
            case "Yellow":
                total = eggAmount * 7;
                break;
        }
        break;
    case "Small":
        switch (eggColor)
        {
            case "Red":
                total = eggAmount * 9;
                break;
            case "Green":
                total = eggAmount * 8;
                break;
            case "Yellow":
                total = eggAmount * 5;
                break;
        }
        break;
}

total -= total * 0.35;

Console.WriteLine($"{total:F2} leva.");