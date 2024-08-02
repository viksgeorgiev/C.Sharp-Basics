// Input

int timeOne = int.Parse(Console.ReadLine());
int timeTwo = int.Parse(Console.ReadLine());
int timeThree = int.Parse(Console.ReadLine());

int time = timeOne + timeTwo + timeThree;

// Calculations

int minutes = time / 60;
int seconds = time % 60;

Console.WriteLine($"{minutes}:{seconds:d2}");