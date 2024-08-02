
double priceForParty = double.Parse(Console.ReadLine());
int loveLetters = int.Parse(Console.ReadLine());
int waxRoses = int.Parse(Console.ReadLine());
int keyChains  = int.Parse(Console.ReadLine());
int caricatures = int.Parse(Console.ReadLine());
int luckyCharms  = int.Parse(Console.ReadLine());

double loveLettersProfit = loveLetters * 0.60;
double waxRosesProfit = waxRoses * 7.20;
double keyChainsProfit = keyChains * 3.60;
double caricaturesProfit = caricatures * 18.20;
double luckyCharmsProfit = luckyCharms * 22;

int sumOfProducts = loveLetters + waxRoses + keyChains + caricatures + luckyCharms;

double totalProfit = loveLettersProfit + waxRosesProfit + keyChainsProfit + caricaturesProfit + luckyCharmsProfit;

if (sumOfProducts >= 25)
{
    totalProfit = totalProfit * 0.65;
}

totalProfit -= totalProfit * 0.10;

if (totalProfit >= priceForParty)
{
    Console.WriteLine($"Yes! {totalProfit - priceForParty:F2} lv left.");
}
else
{
    Console.WriteLine($"Not enough money! {priceForParty - totalProfit:F2} lv needed.");
}