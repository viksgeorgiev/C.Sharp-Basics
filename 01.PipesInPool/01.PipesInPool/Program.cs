//	Първият ред съдържа числото V – Обем на басейна в литри – цяло число в интервала [1…10000].
//	Вторият ред съдържа числото P1 – дебит на първата тръба за час – цяло число в интервала [1…5000].
//	Третият ред съдържа числото P2 – дебит на втората тръба за час– цяло число в интервала [1…5000].
//	Четвъртият ред съдържа числото H – часовете които работникът отсъства – реално число в интервала [1.0…24.00]

int poolV = int.Parse(Console.ReadLine());
int pipe1  = int.Parse(Console.ReadLine());
int pipe2 = int.Parse(Console.ReadLine());
double timeH = double.Parse(Console.ReadLine());

double poolFullness = (pipe1 + pipe2) * timeH;

if (poolFullness > poolV )
{
    Console.WriteLine($"For {timeH} hours the pool overflows with {poolFullness - poolV:F2} liters.");
}
else
{
    Console.WriteLine($"The pool is { poolFullness/poolV * 100}% full. Pipe 1: {(pipe1 * timeH)/poolFullness * 100:F2}%. Pipe 2: {(pipe2 * timeH) / poolFullness * 100:F2}%.");
}