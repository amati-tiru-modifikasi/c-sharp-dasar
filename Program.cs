using System;

class Program
{
    static void Main(string[] args)
    {   
        string value = "102";
        int result = 0;
        if (int.TryParse(value, out result)) {
            Console.WriteLine($"result: {result}");
        }else{
            Console.WriteLine("Gagal dikonversi");
        }
    }
}