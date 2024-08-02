//сума = депозирана сума  + срок на депозита * ((депозирана сума * годишен лихвен процент ) / 12)

//Input


double deposited = double.Parse(Console.ReadLine());
int months = int.Parse(Console.ReadLine());
double interestRate = double.Parse(Console.ReadLine()) / 100;

// Calculations and Output

double sum = (deposited + months * ((deposited * interestRate) / 12));

Console.WriteLine(sum);
