using System;

class Program
{
    static void Main(string[] args)
    {   
        string first = "hello";
        string second = "world";
        Console.WriteLine("{0} {1}!",first, second);
        Console.WriteLine("{0} {1} {0}!",first, second);
    }
}