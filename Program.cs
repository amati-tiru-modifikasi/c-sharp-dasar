using System;

class Program
{
    static void Main(string[] args)
    {   
        string[] pallets = { "B14", "A11", "B12", "A13" };        
        
        Console.WriteLine($"Sorted {pallets}");
        Array.Sort(pallets);
        foreach (var pallet in pallets)
        {
            Console.WriteLine($"-- {pallet}");
        }

        // sorted
        Console.WriteLine("");
        Console.WriteLine("Reversed...");
        Array.Reverse(pallets);
        foreach (var pallet in pallets)
        {
            Console.WriteLine($"-- {pallet}");
        }
    }
}