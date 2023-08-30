using System;

class Program
{
    static void Main(string[] args)
    {
        Random dice = new Random();
        Console.WriteLine(dice.Next(1, 7));

    }
}