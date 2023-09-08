using System;

class Program
{
    static void Main(string[] args)
    {   
        string message = "(What if) I am (only interested) in the last (set of parentheses)?";
        while (true) {
            int openingPosition = message.IndexOf('(');
            if (openingPosition == -1) break; // by default IndexOf() return -1, so break from loop

            openingPosition += 1;
            int closingPosition = message.IndexOf(')');
            int length = closingPosition - openingPosition;
            Console.WriteLine(message.Substring(openingPosition, length));

            // stop the looping while position not meet
            message = message.Substring(closingPosition + 1);
        }

        // int openingPosition = message.LastIndexOf('('); // find last this tag closing in the last position
        // openingPosition += 1;
        // int closingPosition = message.LastIndexOf(')');
        // int length = closingPosition - openingPosition;
        // Console.WriteLine(message.Substring(openingPosition, length));
    }
}