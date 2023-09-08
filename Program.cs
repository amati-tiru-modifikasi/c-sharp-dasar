using System;

class Program
{
    static void Main(string[] args)
    {   
        // Work with different types of symbol sets
        // string message = "Help (find) the {opening symbols}";
        // Console.WriteLine($"Searching THIS Message: {message}");

        // char[] openSymbols ={ '[', '{', '(' };
        // int startPosition = 6;
        // int openingPosition = message.IndexOfAny(openSymbols);
        // Console.WriteLine($"Found WITHOUT using startPosition: {message.Substring(openingPosition)}");

        // openingPosition = message.IndexOfAny(openSymbols, startPosition);
        // Console.WriteLine($"Found WITH using startPosition: {message.Substring(openingPosition)}");

        string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

        // The IndexOfAny() helper method requires a char array of characters. 
        char[] openSymbols =  { '[', '{', '(' };

        // Init closingPosition to 0 for the first iteration
        int closingPosition = 0;

        while(true){
            int openingPosition = message.IndexOfAny(openSymbols, closingPosition);
            if(openingPosition == -1) break;
            string currentSymbol = message.Substring(openingPosition,1);

            // now find match symbol of closing
            char matchingSymbol = ' ';

            switch (currentSymbol)
            {
                case "[":
                    matchingSymbol = ']';
                    break;
                case "{":
                    matchingSymbol = '}';
                    break;
                case "(":
                    matchingSymbol = ')';
                    break;
            }

            // using overload method IndexOf to find specify matchingSymbol in openingPosition string
            openingPosition += 1;
            closingPosition = message.IndexOf(matchingSymbol, openingPosition);

            // display using sub-string technique
            int length = closingPosition - openingPosition;
            Console.WriteLine(message.Substring(openingPosition, length));
        }



    }
}