Console.Write("Enter first number: ");
bool isInt1 = int.TryParse(Console.ReadLine(), out int firstNumber);
Console.Write("Enter second number: ");
bool isInt2 = int.TryParse(Console.ReadLine(), out int secondNumber);

while (!(isInt1 && isInt2))
{
	Console.WriteLine("\nYou entered wrong data");

	Console.Write("\nEnter first number: ");
	isInt1 = int.TryParse(Console.ReadLine(), out firstNumber);

	Console.Write("Enter second number: ");
	isInt2 = int.TryParse(Console.ReadLine(), out secondNumber);
}

try
{
	int result = firstNumber / secondNumber;
	Console.WriteLine($"\n {firstNumber} / {secondNumber} = {firstNumber / secondNumber}");
}
catch (DivideByZeroException ex)
{
	Console.WriteLine(ex.Message);
}