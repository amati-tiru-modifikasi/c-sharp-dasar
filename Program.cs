using System;

class Program
{
    static void Main(string[] args)
    {   
        int value = (int) 1.5m;
        Console.WriteLine(value);

        int valueDua = Convert.ToInt32(1.5m);
        Console.WriteLine(valueDua);
    }
}