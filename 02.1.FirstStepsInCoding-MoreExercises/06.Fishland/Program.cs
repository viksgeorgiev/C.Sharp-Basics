/* Георги ще има гости вечерта и решава да ги нагости с паламуд, сафрид и миди. Затова отива на рибната борса, за да си купи по няколко килограма. 
 * Oт конзолата се въвеждат цените в лева на скумрията и цацата. Също количеството на паламуд, сафрид и миди в килограми. 
 * Колко пари ще са му необходими, за да плати сметката си, ако цените на борсата са:
•	Паламуд – 60% по-скъп от скумрията
•	Сафрид – 80% по-скъп от цацата
•	Миди – 7.50 лв. за килограм
Вход
От конзолата се четат 5 числа:
•	Първи ред – цена на скумрията на килограм. Реално число в интервала [0.00…40.00]
•	Втори ред – цена на цацата на килограм. Реално число в интервала [0.00…30.00]
•	Трети ред – килограма паламуд. Реално число в интервала [0.00…50.00]
•	Четвърти ред – килограма сафрид. Реално число в интервала [0.00… 70.00]
•	Пети ред – килограма миди. Цяло число в интервала [0 ... 100]
Изход
Да се отпечата на конзолата едно число с плаваща запетая: колко пари ще са нужни на Георги, за да си плати сметката. 
Числото трябва да е форматирано до вторият знак след десетичната запетая (1.2457 -> 1.25).
*/

// Input

double skumriqPriceForKg = double.Parse(Console.ReadLine());
double cacaPriceForKg = double.Parse(Console.ReadLine());
double palamudKg = double.Parse((Console.ReadLine()));
double safridKg = double.Parse((Console.ReadLine())); 
double midiKg = double.Parse(Console.ReadLine());

// Calculations

double palamudPrice = skumriqPriceForKg + (skumriqPriceForKg * 0.6);
double safridPrice = cacaPriceForKg + (cacaPriceForKg * 0.8);
double midiCost = midiKg * 7.50;

double costAll = (palamudKg * palamudPrice) + (safridKg * safridPrice) + midiCost;

string roundedCostAll = costAll.ToString("0.00");


// Output

Console.WriteLine(roundedCostAll);