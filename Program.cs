using System;

class Program
{
    static void Main(string[] args)
    {   
        const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

        string quantity = "";
        string output = "";

        // Your work here
        Console.WriteLine($"Kalimat soal: {input}");

        // extract quantity
        int quantityStart = input.IndexOf("<span>");
        int quantityEnd = input.IndexOf("</span>");

        quantityStart += "<span>".Length; // added lenght of tag
        int quantityLength = quantityEnd - quantityStart;
        quantity = input.Substring(quantityStart, quantityLength);
        quantity = $"Quantity: {quantity}";

        // set output to input, replacing the trademark simbol with registred tradmark
        output = input.Replace("&trade;","&reg;");

        // remove div opening
        int divStart = input.IndexOf("<div>");
        int divLength = "<div>".Length;
        output = output.Remove(divStart,divLength);

        // remove div closing
        int divEnd = output.IndexOf("</div>");
        int divEndLength = "</div>".Length;
        output = output.Remove(divEnd, divEndLength);

        output = $"Output: {output}";

        Console.WriteLine(quantity);
        Console.WriteLine(output);
    }
}