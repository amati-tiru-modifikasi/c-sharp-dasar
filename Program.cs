using System;

class Program
{
    static void Main(string[] args)
    {   
        Random koin = new Random();
        int flip = koin.Next(0, 2);
        Console.WriteLine((flip == 0) ? "Heads": "Tails");
    }
}