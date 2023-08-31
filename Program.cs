using System;

class Program
{
    static void Main(string[] args)
    {   
        int[] nomors = { 4,8,15,16,23,42 };
        int total = 0;
        bool found = false;

        foreach (int nomor in nomors)
        {
            total += nomor;

            if (nomor == 42)
            {
                found = true;
            }
        }

        if(found){
            Console.WriteLine($"{found} Set contains 42");
        }

        Console.WriteLine($"Total: {total}");
    }
}