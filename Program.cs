using System;

class Program
{
    static void Main(string[] args)
    {   
        string value = "abc123";
        char[] valueArray = value.ToCharArray();
        Array.Reverse(valueArray);
        // string result  = new string(valueArray);
        string result = String.Join(",",valueArray);
        Console.WriteLine(result);

        // Split array
        Console.WriteLine("");
        Console.WriteLine("Split Array..");
        string[] items =  result.Split(",");
        foreach (string item in items)
        {
            Console.WriteLine(item);
        }
    }
}