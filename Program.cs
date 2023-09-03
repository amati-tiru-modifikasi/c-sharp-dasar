using System;

class Program
{
    static void Main(string[] args)
    {   
        decimal myDesimal = 3.14m;
        Console.WriteLine($"Desimal: {myDesimal}");

        int myInt = (int) myDesimal;
        Console.WriteLine($"Integer: {myInt}");        
    }
}