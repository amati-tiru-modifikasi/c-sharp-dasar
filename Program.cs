using System;

class Program
{
    static void Main(string[] args)
    {   
        string[] values = { "12.3", "45", "ABC", "11", "DEF" };

        decimal total = 0m;
        string message = "";

        foreach (string item in values)
        {
            decimal number;
            if(decimal.TryParse(item, out number)){
                total += number;
            }else{
                message += item;
            }
        }

        Console.WriteLine($"Message: {message}");
        Console.WriteLine($"Total: {total}");

        // string value = "bad";
        // int result = 0;
        // if (int.TryParse(value, out result)) {
        //     Console.WriteLine($"result: {result}");
        // }else{
        //     Console.WriteLine("Gagal dikonversi");
        // }

        // if (result > 0)
        //     Console.WriteLine($"Terukur dengan offset: {50 + result}");
    }
}