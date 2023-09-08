using System;

class Program
{
    static void Main(string[] args)
    {   
        // Remove characters in specific locations from a string
        string data = "12345John Smith          5000  3  ";
        string updateData = data.Remove(5, 20);
        Console.WriteLine(updateData);

        string message = "This--is--ex-amp-le--da-ta";
        Console.WriteLine("");
        Console.WriteLine($"Using Replace() method: {message}");
        message = message.Replace("--", " ");
        message = message.Replace("-","");
        Console.WriteLine(message);

    }
}