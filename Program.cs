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
        // Console.WriteLine();
        // Console.WriteLine("Resize...");
        // Array.Clear(pallets, 0, 2);
        // Console.WriteLine($"Clearing 2... count: {pallets.Length}");
        // foreach (var pallet in pallets)
        // {
        //     Console.WriteLine($"-- {pallet}");
        // }

        // clear element
        Console.WriteLine("");
        Console.WriteLine("Clear element...");
        Console.WriteLine($"Before: {pallets[0]}");
        Array.Clear(pallets,0,2);
        Console.WriteLine($"After: {pallets[0]}");

        Console.WriteLine($"Clearing 2 .... count: {pallets.Length}");
        foreach (var pallet in pallets)
        {
            Console.WriteLine($"-- {pallet}");
        }

        // Check Null
        Console.WriteLine("");
        Console.WriteLine("Check null...");
        if (pallets[0] != null)
            Console.WriteLine($"Before: {pallets[0].ToLower()}");
        Array.Clear(pallets,0,2);
        if (pallets[0] != null)
            Console.WriteLine($"After: {pallets[0].ToLower()}");
        Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
        foreach (var pallet in pallets)
        {
            Console.WriteLine($"-- {pallet}");
        }

        // Resize and Add More
        Console.WriteLine("");
        Console.WriteLine("Resize and add more...");
        Array.Resize(ref pallets,6);
        Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");   

        pallets[4] = "C01";
        pallets[5] = "C02";

        foreach (var pallet in pallets)
        {
            Console.WriteLine($"-- {pallet}");
        }

        /*
        RECAP:
        - Use the Clear() method to empty the values out of elements in the array.
        - Use the Resize() method to change the number of elements in the array, removing or adding elements from the end of the array.
        - New array elements and cleared elements are null, meaning they don't point to a value in memory.
        */
    }
}