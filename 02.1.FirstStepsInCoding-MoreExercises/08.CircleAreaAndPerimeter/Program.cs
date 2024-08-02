/* Напишете програма, която чете от конзолата число r и пресмята и отпечатва лицето и периметъра на кръг / окръжност с радиус r, 
 * като форматирате изхода в следния вид: "<calculated area>" 
"<calculated parameter>". Форматирайте изходните данни до втория знак след десетичната запетая.
*/

// Input

double rInput = double.Parse(Console.ReadLine());

// Calculations

double areaCircle = Math.PI * (rInput * rInput);

double circumferenceCircle = 2 * Math.PI * rInput;

string formattedAreaCircle = areaCircle.ToString("0.00");
string formattedCircumferenceCircle = circumferenceCircle.ToString("0.00");

//Output

Console.WriteLine(formattedAreaCircle);
Console.WriteLine(formattedCircumferenceCircle);