using System;

class Program
{
    static void Main(string[] args)
    {   
        string[] names = { "Alex", "Eddie", "David", "Michael" };
        for (int i = names.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(names[i]);
        }
    }
}