

// Input

int yearTax = int.Parse(Console.ReadLine());

// Calcualtions

double trainers = yearTax * 0.6;
double tracksuit = trainers * 0.8;
double ball = tracksuit / 4;
double accessories = ball / 5;

// Output

Console.WriteLine(yearTax + trainers + tracksuit + ball + accessories);