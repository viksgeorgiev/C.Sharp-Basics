// Input

double squareFootage = double.Parse(Console.ReadLine());

// Calculations

double priceFull = squareFootage * 7.61;
double discount = priceFull * 0.18;
double priceFinal = priceFull - discount;

// Output

Console.WriteLine($"The final price is: {priceFinal} lv.");
Console.WriteLine($"The discount is: {discount} lv.");