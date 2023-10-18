// Prompt user
Console.Write("Enter the lower bound: ");
int lowerBound = int.Parse(Console.ReadLine());

Console.Write("Enter the upper bound: ");
int upperBound = int.Parse(Console.ReadLine());

decimal averageValue = 0;

// calculate the sum of the even numbers between the bound
averageValue = AverageOfEvenNumbers(lowerBound, upperBound);

// display value returned by averate of even number in the console
Console.WriteLine($"The average of even number between {lowerBound} and {upperBound} is {averageValue}");

// Wait for user input 
Console.ReadLine();

static decimal AverageOfEvenNumbers(int lowerBound, int upperBound)
{
    int sum = 0;
    int count = 0;
    decimal average = 0;

    for (int i = lowerBound; i <= upperBound; i++)
    {
        if (i % 2 == 0)
        {
            sum += i;
            count++;
        }
    }
    average = (decimal)sum / count;
    return average;

}