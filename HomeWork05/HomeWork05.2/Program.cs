try
{
	int userInput = int.Parse(Console.ReadLine());
	Console.WriteLine($"You entered correct number: {userInput}");
}
catch (FormatException ex)
{
	Console.WriteLine(ex.Message);
}
catch (OverflowException ex)
{
	Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}