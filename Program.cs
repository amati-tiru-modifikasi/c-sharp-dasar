using System;

class Program
{
    static void Main(string[] args)
    {   
        string first = "hello";
        string second = "world";
        Console.WriteLine($"{first} {second}!");
        Console.WriteLine($"{second} {first}!");
        Console.WriteLine($"{first} {first} {first}!");
    }
}