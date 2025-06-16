int userInput = 0;

Console.Write("Enter number: ");

try
{
	userInput = int.Parse(Console.ReadLine());
	Console.WriteLine($"Entered number: {userInput}");
}
catch (Exception ex)
{
	Console.WriteLine(ex.Message);
}