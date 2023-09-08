using System;

class Program
{
    static void Main(string[] args)
    {   
        string message = "(What if) I am (only interested) in the last (set of parentheses)?";
        int openingPosition = message.LastIndexOf('('); // find last this tag closing in the last position

        openingPosition += 1;
        int closingPosition = message.LastIndexOf(')');
        int length = closingPosition - openingPosition;
        Console.WriteLine(message.Substring(openingPosition, length));
    }
}