﻿using System;

class Program
{
    static void Main(string[] args)
    {   
        int invoiceNumber = 1201;
        decimal productShares = 25.4568m;
        decimal subtotal = 2750.00m;
        decimal taxPercentage = .15825m;
        decimal total = 3185.19m;

        Console.WriteLine($"Invoice Number: {invoiceNumber}");
        Console.WriteLine($"Shares: {productShares:N3} Product");
        Console.WriteLine($"Sub Total: {subtotal:C} Product");
        Console.WriteLine($"Tax: {taxPercentage:P2} Product");
        Console.WriteLine($"Total Billed: {total:C} Product");
    
    }
}