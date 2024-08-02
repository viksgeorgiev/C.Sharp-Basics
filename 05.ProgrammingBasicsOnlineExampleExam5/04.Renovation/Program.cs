//От конзолата се четат следните редове:
//1.Височина на стената - цяло число [0… 100]
//2.Ширина на стената - цяло число [0… 100]
//3.Процент от общата площ на стените, който няма да бъде боядисан - цяло число [5… 95]
//На следващите редове до получаване на командата "Tired!" или докато не бъдат боядисани всички стени, се чете по едно число:
//•	Литри боя – цяло число [0…100]:
//Забележка: Площта за боядисване да бъде закръглена нагоре до най-близкото цяло число.

int heightWall = int.Parse(Console.ReadLine());
int widthWall = int.Parse(Console.ReadLine());
int percentNotPainted = int.Parse(Console.ReadLine());

double footageToBePainted = heightWall * widthWall * 4;
footageToBePainted -= Math.Ceiling(footageToBePainted * ((double)percentNotPainted / 100));
double footagePainted = 0;
string input = Console.ReadLine();

while(true)
{
    int litersUsed = int.Parse(input);
    footagePainted += litersUsed;

    input = Console.ReadLine();

    if (footagePainted > footageToBePainted)
    {
        Console.WriteLine($"All walls are painted and you have {footagePainted - footageToBePainted} l paint left!");
        break;
    }
    else if (footagePainted == footageToBePainted)
    {
        Console.WriteLine("All walls are painted! Great job, Pesho!");
        break;
    }
    else if (input == "Tired!")
    {
        Console.WriteLine($"{footageToBePainted - footagePainted} quadratic m left.");
        break;
    }
}
