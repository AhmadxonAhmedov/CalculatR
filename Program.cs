
// This project added 2 numbers
Console.Write("Enter first input: "); 
string firstInput = Console.ReadLine();
Console.Write("Enter second input: ");
string secondInput = Console.ReadLine();
Console.WriteLine($"{firstInput}dasdfas{secondInput}");

Console.WriteLine("Converting your inputs...");
int firstNumber = Convert.ToInt32(firstInput);
int secondNumber = Convert.ToInt32(secondInput);
Console.WriteLine("Calculating operation...");
Console.Write("RESULT: ");
Console.WriteLine(firstNumber + secondNumber);
