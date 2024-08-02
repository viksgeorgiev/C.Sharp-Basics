
int paperRolls = int.Parse(Console.ReadLine());
int fabricRolls = int.Parse(Console.ReadLine());
double glueInLiters  = double.Parse(Console.ReadLine());
int percentDiscount = int.Parse(Console.ReadLine());

double paperRollsPrice = paperRolls * 5.80;
double fabricRollsPrice = fabricRolls * 7.20;
double glueInLitersPrice = glueInLiters * 1.20;

double sumOfMaterials  = paperRollsPrice + fabricRollsPrice + glueInLitersPrice;

sumOfMaterials = sumOfMaterials - (sumOfMaterials * ((double)percentDiscount / 100));

Console.WriteLine($"{sumOfMaterials:F3}");