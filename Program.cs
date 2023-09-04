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

        // clear and resize
        Console.WriteLine();
        Console.WriteLine("Resize...");
        Array.Clear(pallets, 0, 2);
        Console.WriteLine($"Clearing 2... count: {pallets.Length}");
        foreach (var pallet in pallets)
        {
            Console.WriteLine($"-- {pallet}");
        }
    }
}