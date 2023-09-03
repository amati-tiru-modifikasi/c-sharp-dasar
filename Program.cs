using System;

class Program
{
    static void Main(string[] args)
    {   
        decimal myDesimal = 1.23456789m;
        float myFloat = (float) myDesimal;

        Console.WriteLine($"Desimal: {myDesimal}");
        Console.WriteLine($"Float: {myFloat}");      
    }
}