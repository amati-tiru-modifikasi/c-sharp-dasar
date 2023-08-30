using System;

class Program
{
    static void Main(string[] args)
    {   
        Random dice = new Random();

        int roll1 = dice.Next(); // 0 to 2,147,483,647
        int roll2 = dice.Next(101); // 0 to 100
        int roll3 = dice.Next(50, 101); // 50 to 100

        Console.WriteLine($"First roll: {roll1}");
        Console.WriteLine($"Second roll: {roll2}");
        Console.WriteLine($"Third roll: {roll3}");
        
    }
}