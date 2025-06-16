bool isInt1 = false;
bool isInt2 = false;
int firstNumber = 0;
int secondNumber = 0;


while (!(isInt1 && isInt2))
{
	Console.Write("Enter first number: ");
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