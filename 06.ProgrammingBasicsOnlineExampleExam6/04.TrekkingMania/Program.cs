
int groupsCount = int.Parse(Console.ReadLine());

int counterMusala = 0;
int counterMonblan = 0;
int counterKilimandjaro = 0;
int counterK2 = 0;
int counterEverest = 0;


for (int i = 1; i <= groupsCount; i++)
{
    int peopleInGroup = int.Parse(Console.ReadLine());

    if (peopleInGroup <= 5)
    {
        counterMusala += peopleInGroup;
    }
    else if (peopleInGroup >= 6 && peopleInGroup <= 12) 
    {
        counterMonblan += peopleInGroup;
    }
    else if (peopleInGroup >= 13 && peopleInGroup <= 25)
    {
        counterKilimandjaro += peopleInGroup;
    }
    else if (peopleInGroup >= 26 && peopleInGroup <= 40)
    {
        counterK2 += peopleInGroup;
    }
    else if (peopleInGroup >= 41)
    {
        counterEverest += peopleInGroup;
    }
}

double allPeople = counterMusala + counterMonblan + counterKilimandjaro + counterK2 + counterEverest;


Console.WriteLine($"{(counterMusala / allPeople) * 100:F2}%");
Console.WriteLine($"{(counterMonblan / allPeople) * 100:F2}%");
Console.WriteLine($"{(counterKilimandjaro / allPeople) * 100:F2}%");
Console.WriteLine($"{(counterK2 / allPeople) * 100:F2}%");
Console.WriteLine($"{(counterEverest / allPeople) * 100:F2}%");