int numberOfPcs = int.Parse(Console.ReadLine());
string numberRatingAndSales  = String.Empty;

int rating = 0;
int salesProjected = 0;

double salesMade = 0;
double allSales = 0;
double sumOfRatings = 0;


for (int i = 1; i <= numberOfPcs; i++)
{
    numberRatingAndSales = Console.ReadLine();

    rating = int.Parse(numberRatingAndSales[2].ToString());
    salesProjected = int.Parse(numberRatingAndSales[0].ToString()) * 10 + int.Parse(numberRatingAndSales[1].ToString());

    sumOfRatings += rating; 

    switch (rating)
    {
        case 2:
            salesMade = salesProjected * 0;
            break;
        case 3:
            salesMade = salesProjected * 0.50;
            break;
        case 4:
            salesMade = salesProjected * 0.70;
            break;
        case 5:
            salesMade = salesProjected * 0.85;
            break;
        case 6:
            salesMade = salesProjected;
            break;
    }
    allSales += salesMade;
}

double avgRating = sumOfRatings / numberOfPcs;

Console.WriteLine($"{allSales:F2}");
Console.WriteLine($"{avgRating:F2}");






