// inputValues is used to store numeric values entered by a user
string[] inputValues = new string[]{"three", "999999999", "0", "2"};

foreach (string inputValue in inputValues)
{
    int numValue = 0;
    try
    {
        numValue = int.Parse(inputValue);
    }
    catch (FormatException)
    {
        Console.WriteLine("Invalid readResult, Please enter a valid number");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}