using System;

class Program
{
    static void Main(string[] args)
    {   
        string first = "hello";
        string second = "world";
        string result = string.Format("{0} {1}!",first, second);
        Console.WriteLine(result);
    }
}