
//            Сезон	    Хризантеми	    Рози	        Лалета
//    Пролет / Лято	    2.00 лв./бр.	4.10 лв./бр.	2.50 лв./бр.
//      Есен / Зима	    3.75 лв./бр.	4.50 лв./бр.	4.15 лв./бр.
//В празнични дни цените на всички цветя се увеличават с 15%. Предлагат се следните отстъпки:
//	За закупени повече от 7 лалета през пролетта – 5% от цената на целият букет.
//	За закупени 10 или повече рози през зимата – 10% от цената на целият букет.
//	За закупени повече от 20 цветя общо през всички сезони – 20% от цената на целият букет.
//Отстъпките се правят по така написания ред и могат да се наслагват!
//Всички отстъпки важат след оскъпяването за празничен ден!
//Цената за аранжиране на букета винаги е 2лв.
//Напишете програма, която изчислява цената за един букет.




int chrysanthemumQuantity = int.Parse(Console.ReadLine());
int rosesQuantity  = int.Parse(Console.ReadLine());
int tulipsQuantity  = int.Parse(Console.ReadLine());
string season = Console.ReadLine();
string holiday = Console.ReadLine();

double total = 0;

if (season == "Spring" || season == "Summer")
{
    if (holiday == "Y")
    {
        total = chrysanthemumQuantity * (2.0 + (2.0 * 0.15))
                + rosesQuantity * (4.10 + (4.10 * 0.15))
                + tulipsQuantity * (2.50 + (2.50 * 0.15));
    }
    else 
    {
        total = chrysanthemumQuantity * 2.0
                + rosesQuantity * 4.10 
                + tulipsQuantity * 2.50;
    }
}
else 
{
    if (holiday == "Y")
    {
        total = chrysanthemumQuantity * (3.75 + (3.75 * 0.15))
               + rosesQuantity * (4.50 + (4.50 * 0.15))
               + tulipsQuantity * (4.15 + (4.15 * 0.15));
    }
    else 
    {
        total = chrysanthemumQuantity * 3.75
                + rosesQuantity * 4.50
                + tulipsQuantity * 4.15;
    }
}

if (season == "Spring" && tulipsQuantity > 7)
{
    total -= total * 0.05;
}

if (season == "Winter" && rosesQuantity >= 10)
{
    total -= total * 0.1;
}

if (chrysanthemumQuantity + rosesQuantity + tulipsQuantity > 20)
{
    total -= total * 0.2;
}

total += 2;

Console.WriteLine($"{total:F2}");