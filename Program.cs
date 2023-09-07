using System;

class Program
{
    static void Main(string[] args)
    {   
        string message = "Find what is (inside the parentheses)";
        string messageDua = "What is the value <span>between the tags</span>?";

        int openingPosition = message.IndexOf('(');
        int closingPosition = message.IndexOf(')');

        const string openSpan = "<span>";
        const string closingSpan = "</span>";
        int openingPositionDua = messageDua.IndexOf(openSpan);
        int closingPositionDua = messageDua.IndexOf(closingSpan);

        Console.WriteLine("");
        Console.WriteLine("Lenght panjang...");
        Console.WriteLine(openingPosition);
        Console.WriteLine(closingPosition);

        Console.WriteLine("");
        Console.WriteLine("Between parenthis...");

        int panjang = closingPosition - openingPosition;
        Console.WriteLine(message.Substring(openingPosition, panjang)); 

        Console.WriteLine("");
        Console.WriteLine("Modify posistion of string");

        openingPosition += 1;
        int panjangDua = closingPosition - openingPosition;
        Console.WriteLine(message.Substring(openingPosition, panjangDua));


        Console.WriteLine("");
        Console.WriteLine("Message ke dua");

        openingPositionDua += openSpan.Length;
        int length = closingPositionDua - openingPositionDua;
        Console.WriteLine(messageDua.Substring(openingPositionDua, length));
    }
}