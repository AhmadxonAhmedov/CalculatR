Console.WriteLine("Kichik calculator loyixasi:   ");

Console.Write("Birinchi raqamni kiriting:   ");
decimal firstNumber = decimal.Parse(Console.ReadLine());

Console.Write("Matematik belgini kiriting: ( + - * / % ):  ");
char matemBelgi = char.Parse(Console.ReadLine());

Console.Write("Ikkinchi raqamni kiriting   ");
decimal secondNumber = decimal.Parse(Console.ReadLine());
 
decimal result = matemBelgi switch 
{
   '+' => firstNumber + secondNumber,
   '-' => firstNumber - secondNumber,
   '*' => firstNumber * secondNumber,
   '/' => firstNumber / secondNumber,
   '%' => firstNumber % secondNumber,
   _ => throw new ("Siz noto`g`ri matematik belgi kiritdingiz, qayta urinib ko`ring")
   
};

Console.WriteLine($"RUSELT {firstNumber} {matemBelgi} {secondNumber} = {result} ");
