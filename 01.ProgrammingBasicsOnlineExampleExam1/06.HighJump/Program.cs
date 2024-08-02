int wantedHeight = int.Parse(Console.ReadLine());

int startHeight = wantedHeight - 30;

int jumpsCounter = 0;
int failedCounter = 0;

bool isFailed = false;

int heightJumped = int.Parse(Console.ReadLine());

while (true)
{
    
    if (heightJumped > startHeight )
    {
        jumpsCounter++;
        if (wantedHeight > startHeight)
        { startHeight += 5; }
        else if (heightJumped > wantedHeight)
            { break; }
        failedCounter = 0;
    }
    else 
    {
        jumpsCounter++;
        failedCounter++;
    }

    if (failedCounter == 3) 
    {
        isFailed = true;
        Console.WriteLine($"Tihomir failed at {startHeight}cm after {jumpsCounter} jumps.");
        break;
    }

    
    heightJumped = int.Parse(Console.ReadLine());
}

if (!isFailed)
{
    Console.WriteLine($"Tihomir succeeded, he jumped over {startHeight}cm after {jumpsCounter} jumps.");
}



