Console.Write("Enter number: ");
bool isInt = int.TryParse(Console.ReadLine(), out int userInput);

try
{
	if (!isInt)
	{
		throw new Exception("You entered invalid data");
	}
	
	Console.WriteLine($"Entered number: {userInput}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}