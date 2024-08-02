using System;

int eggsColored = int.Parse(Console.ReadLine());

int redEggs = 0;
int orangeEggs = 0;
int blueEggs  = 0;
int greenEggs = 0;


for (int i = 1; i <= eggsColored; i++)
{
    string input = Console.ReadLine();
    if (input == "red")
    {
        redEggs++;
    }
    else if (input == "blue")
    {
        blueEggs++;
    }
    else if (input == "green")
    {
        greenEggs++;
    }
    else 
    {
        orangeEggs++;
    }
}




Console.WriteLine($"Red eggs: {redEggs}");
Console.WriteLine($"Orange eggs: {orangeEggs}");
Console.WriteLine($"Blue eggs: {blueEggs}");
Console.WriteLine($"Green eggs: {greenEggs}");
if (redEggs > greenEggs && redEggs > orangeEggs && redEggs > blueEggs) 
{ Console.WriteLine($"Max eggs: {redEggs} -> red"); }
if (greenEggs > redEggs && greenEggs > orangeEggs && greenEggs > blueEggs)
{ Console.WriteLine($"Max eggs: {greenEggs} -> green"); }
if (blueEggs > greenEggs && blueEggs > orangeEggs && blueEggs > redEggs)
{ Console.WriteLine($"Max eggs: {blueEggs} -> blue"); }
if (orangeEggs > greenEggs && orangeEggs > redEggs && orangeEggs > blueEggs)
{ Console.WriteLine($"Max eggs: {orangeEggs} -> orange"); }
