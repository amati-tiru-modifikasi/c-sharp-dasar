using System;

class Program
{
    static void Main(string[] args)
    {   
        int value1 = 12;
        decimal value2 = 6.2m;
        float value3 = 4.3f;

        int result1 = Convert.ToInt32((decimal)value1 / value2);
        decimal result2 = value2 / (decimal)value3;
        float result3 = value3 / value1;
     
        // Your code here to set result1
        // Hint: You need to round the result to nearest integer (don't just truncate)
        Console.WriteLine($"Pembagian value1 by value2, display the result as an int: {result1}");

        // Your code here to set result2
        Console.WriteLine($"Pembagian value2 by value3, display the result as a decimal: {result2}");

        // Your code here to set result3
        Console.WriteLine($"Pembagian value3 by value1, display the result as a float: {result3}");

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