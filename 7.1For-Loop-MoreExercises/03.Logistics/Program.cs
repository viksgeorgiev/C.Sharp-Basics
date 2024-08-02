int loads = int.Parse(Console.ReadLine());

double sum = 0;
int van = 0;
int truck = 0;
int train = 0;
double pricePerTon = 0;

for (int i = 1; i <= loads; i++)
{
    int loadTons = int.Parse(Console.ReadLine());
    if (loadTons <= 3)
    {
        van += loadTons;
    }
    else if (loadTons <= 11) 
    {
        truck += loadTons;
    }
    else
    {
        train += loadTons;
    }
}

sum = van + truck + train;
pricePerTon = ((van * 200) + (truck * 175) + (train * 120 )) / sum;

Console.WriteLine($"{pricePerTon:F2}");
Console.WriteLine($"{(van / sum) * 100:F2}%");
Console.WriteLine($"{(truck / sum) * 100:F2}%");
Console.WriteLine($"{train / sum * 100:F2}%");