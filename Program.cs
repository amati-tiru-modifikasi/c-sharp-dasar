using System;

class Program
{
    static void Main(string[] args)
    {   
        // string first = "Hello";
        // string second = "World";
        // string result = string.Format("{0} {1}!", first, second);
        // Console.WriteLine(result);

        // string input = "Pad this";
        // Console.WriteLine(input.PadRight(12, '-'));	

        // string paymentId = "769C";
        // var formattedLine = paymentId.PadRight(6);
        // Console.WriteLine(formattedLine);

        string paymentId = "769";
        string payeeName = "Mr. Stephen Ortega";
        string paymentAmount = "$5,000.00";

        var formattedLine = paymentId.PadRight(6);
        formattedLine += payeeName.PadRight(24);
        formattedLine += paymentAmount.PadRight(10);

        // sama dengan ini
        // formattedLine = formattedLine + payeeName.PadRight(24);

        Console.WriteLine(formattedLine);
    
    }
}