// Input
string architectName = Console.ReadLine();
int projectsInput = int.Parse(Console.ReadLine());
// Calculations
int hoursWork = projectsInput * 3;
// Output
Console.WriteLine($"The architect {architectName} will need {hoursWork} hours to complete {projectsInput} project/s.");