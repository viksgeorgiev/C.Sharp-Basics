int yearsTax = int.Parse(Console.ReadLine());

double trainers = yearsTax - (yearsTax * 0.40);
double uniform = trainers - (trainers * 0.20);
double ball = uniform / 4;
double accessories = ball / 5;

double moneyNeeded = yearsTax + trainers + uniform + ball + accessories;

Console.WriteLine($"{moneyNeeded:F2}");