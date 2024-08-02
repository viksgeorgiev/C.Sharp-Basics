int movieLiked = int.Parse(Console.ReadLine());

string lowestScored = string.Empty;
double lowestScore = double.MaxValue;
string highestScored = string.Empty;
double highestScore = double.MinValue;

double allRating = 0;

for (int i = 1; i <= movieLiked; i++)
{
    string movie = Console.ReadLine();
    double rating = double.Parse(Console.ReadLine());

    allRating += rating;

    if (rating > highestScore)
    {
        highestScored = movie;
        highestScore = rating;
    }
    else if (rating < lowestScore) 
    {
        lowestScored = movie;
        lowestScore = rating;
    }
    
}

double avgRating = allRating / movieLiked;

Console.WriteLine($"{highestScored} is with highest rating: {highestScore:F1}");
Console.WriteLine($"{lowestScored} is with lowest rating: {lowestScore:F1}");
Console.WriteLine($"Average rating: {avgRating:F1}");
